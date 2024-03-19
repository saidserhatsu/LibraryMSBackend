using Application.Features.LibraryStaffs.Constants;
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

namespace Application.Features.LibraryStaffs.Commands.Delete;

public class DeleteLibraryStaffCommand : IRequest<DeletedLibraryStaffResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, LibraryStaffsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLibraryStaffs"];

    public class DeleteLibraryStaffCommandHandler : IRequestHandler<DeleteLibraryStaffCommand, DeletedLibraryStaffResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;

        public DeleteLibraryStaffCommandHandler(IMapper mapper, ILibraryStaffRepository libraryStaffRepository,
                                         LibraryStaffBusinessRules libraryStaffBusinessRules)
        {
            _mapper = mapper;
            _libraryStaffRepository = libraryStaffRepository;
            _libraryStaffBusinessRules = libraryStaffBusinessRules;
        }

        public async Task<DeletedLibraryStaffResponse> Handle(DeleteLibraryStaffCommand request, CancellationToken cancellationToken)
        {
            LibraryStaff? libraryStaff = await _libraryStaffRepository.GetAsync(predicate: ls => ls.Id == request.Id, cancellationToken: cancellationToken);
            await _libraryStaffBusinessRules.LibraryStaffShouldExistWhenSelected(libraryStaff);

            await _libraryStaffRepository.DeleteAsync(libraryStaff!);

            DeletedLibraryStaffResponse response = _mapper.Map<DeletedLibraryStaffResponse>(libraryStaff);
            return response;
        }
    }
}