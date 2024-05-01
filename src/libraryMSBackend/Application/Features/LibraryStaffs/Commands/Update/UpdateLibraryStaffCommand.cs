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
using Microsoft.AspNetCore.Http;
using Application.Services.ImageService;

namespace Application.Features.LibraryStaffs.Commands.Update;

public class UpdateLibraryStaffCommand : IRequest<UpdatedLibraryStaffResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public IFormFile? File { get; set; } // Resim dosyasý
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public string[] Roles => [Admin, Write, LibraryStaffsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLibraryStaffs"];

    public class UpdateLibraryStaffCommandHandler : IRequestHandler<UpdateLibraryStaffCommand, UpdatedLibraryStaffResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly ImageServiceBase _imageService;
        private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;

        public UpdateLibraryStaffCommandHandler(IMapper mapper, ILibraryStaffRepository libraryStaffRepository,
                                         LibraryStaffBusinessRules libraryStaffBusinessRules, ImageServiceBase imageService)
        {
            _mapper = mapper;
            _libraryStaffRepository = libraryStaffRepository;
            _libraryStaffBusinessRules = libraryStaffBusinessRules;
            _imageService = imageService;
        }

        public async Task<UpdatedLibraryStaffResponse> Handle(UpdateLibraryStaffCommand request, CancellationToken cancellationToken)
        {
            LibraryStaff? libraryStaff = await _libraryStaffRepository.GetAsync(predicate: ls => ls.Id == request.Id, cancellationToken: cancellationToken);
            await _libraryStaffBusinessRules.LibraryStaffShouldExistWhenSelected(libraryStaff);
            
            if (request.File != null)
            {
                // Yeni resim yükleme
                string newImageUrl = await _imageService.UploadAsync(request.File);

                // Eski resmi sil (eðer eski resim URL'si varsa)
                if (!string.IsNullOrEmpty(libraryStaff?.ImageUrl))
                {
                    await _imageService.DeleteAsync(libraryStaff.ImageUrl);
                }

                // Yeni URL'yi güncelle
                libraryStaff.ImageUrl = newImageUrl;
            }


            libraryStaff = _mapper.Map(request, libraryStaff);

            await _libraryStaffRepository.UpdateAsync(libraryStaff!);

            UpdatedLibraryStaffResponse response = _mapper.Map<UpdatedLibraryStaffResponse>(libraryStaff);
            return response;
        }
    }
}