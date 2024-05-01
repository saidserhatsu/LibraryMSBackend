using Application.Features.LibraryStaffs.Constants;
using Application.Features.LibraryStaffs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.LibraryStaffs.Constants.LibraryStaffsOperationClaims;
using Application.Services.UsersService;
using NArchitecture.Core.Application.Dtos;
using Application.Services.OperationClaims;
using Application.Services.UserOperationClaims;
using Microsoft.AspNetCore.Http;
using Application.Services.ImageService;
using AutoMapper.Execution;

namespace Application.Features.LibraryStaffs.Commands.Create;

public class CreateLibraryStaffCommand : IRequest<CreatedLibraryStaffResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public IFormFile File { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }

    public string[] Roles => [Admin, Write, LibraryStaffsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLibraryStaffs"];

    public class CreateLibraryStaffCommandHandler : IRequestHandler<CreateLibraryStaffCommand, CreatedLibraryStaffResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;
        private readonly IUserService _userService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IOperationClaimService _operationClaimService;
        private readonly ImageServiceBase _imageService;

        public CreateLibraryStaffCommandHandler(IMapper mapper, ILibraryStaffRepository libraryStaffRepository,
                                         LibraryStaffBusinessRules libraryStaffBusinessRules, IUserService userService, IOperationClaimService operationClaimService, IUserOperationClaimService userOperationClaimService, ImageServiceBase imageService)
        {
            _mapper = mapper;
            _libraryStaffRepository = libraryStaffRepository;
            _libraryStaffBusinessRules = libraryStaffBusinessRules;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _operationClaimService = operationClaimService;
            _imageService = imageService;
        }

        public async Task<CreatedLibraryStaffResponse> Handle(CreateLibraryStaffCommand request, CancellationToken cancellationToken)
        {
            User user = await _userService.Register(new UserForRegisterDto() { Email = request.Email, Password = request.Password });
            string[] Roles = UserDefaultRoles.Roles;
            for (int i = 0; i < Roles.Length; i++)
            {
                OperationClaim? operationClaim = await _operationClaimService.GetAsync(oc => oc.Name == Roles[i]);
                await _userOperationClaimService.AddAsync(new UserOperationClaim() { UserId = user.Id, OperationClaimId = operationClaim!.Id });
            }

            LibraryStaff libraryStaff = _mapper.Map<LibraryStaff>(request);
            libraryStaff.UserId = user.Id;

            // Fotoðrafý yükle ve URL'yi al

            string imageUrl = string.Empty;
            if (request.File != null)
            {
                imageUrl = await _imageService.UploadAsync(request.File);
                libraryStaff.ImageUrl = imageUrl; // Resim URL'sini ata

            }



            await _libraryStaffRepository.AddAsync(libraryStaff);

            CreatedLibraryStaffResponse response = _mapper.Map<CreatedLibraryStaffResponse>(libraryStaff);
            response.ImageUrl = imageUrl;

            return response;
        }
    }
}