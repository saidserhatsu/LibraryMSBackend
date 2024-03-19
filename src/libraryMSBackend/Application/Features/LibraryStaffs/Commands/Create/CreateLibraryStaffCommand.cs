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

namespace Application.Features.LibraryStaffs.Commands.Create;

public class CreateLibraryStaffCommand : IRequest<CreatedLibraryStaffResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Image { get; set; }

    public string[] Roles => [Admin, Write, LibraryStaffsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLibraryStaffs"];

    public class CreateLibraryStaffCommandHandler : IRequestHandler<CreateLibraryStaffCommand, CreatedLibraryStaffResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;

        public CreateLibraryStaffCommandHandler(IMapper mapper, ILibraryStaffRepository libraryStaffRepository,
                                         LibraryStaffBusinessRules libraryStaffBusinessRules)
        {
            _mapper = mapper;
            _libraryStaffRepository = libraryStaffRepository;
            _libraryStaffBusinessRules = libraryStaffBusinessRules;
        }

        public async Task<CreatedLibraryStaffResponse> Handle(CreateLibraryStaffCommand request, CancellationToken cancellationToken)
        {
            LibraryStaff libraryStaff = _mapper.Map<LibraryStaff>(request);

            await _libraryStaffRepository.AddAsync(libraryStaff);

            CreatedLibraryStaffResponse response = _mapper.Map<CreatedLibraryStaffResponse>(libraryStaff);
            return response;
        }
    }
}