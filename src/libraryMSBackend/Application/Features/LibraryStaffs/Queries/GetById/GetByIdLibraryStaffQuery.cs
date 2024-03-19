using Application.Features.LibraryStaffs.Constants;
using Application.Features.LibraryStaffs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.LibraryStaffs.Constants.LibraryStaffsOperationClaims;

namespace Application.Features.LibraryStaffs.Queries.GetById;

public class GetByIdLibraryStaffQuery : IRequest<GetByIdLibraryStaffResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdLibraryStaffQueryHandler : IRequestHandler<GetByIdLibraryStaffQuery, GetByIdLibraryStaffResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;

        public GetByIdLibraryStaffQueryHandler(IMapper mapper, ILibraryStaffRepository libraryStaffRepository, LibraryStaffBusinessRules libraryStaffBusinessRules)
        {
            _mapper = mapper;
            _libraryStaffRepository = libraryStaffRepository;
            _libraryStaffBusinessRules = libraryStaffBusinessRules;
        }

        public async Task<GetByIdLibraryStaffResponse> Handle(GetByIdLibraryStaffQuery request, CancellationToken cancellationToken)
        {
            LibraryStaff? libraryStaff = await _libraryStaffRepository.GetAsync(predicate: ls => ls.Id == request.Id, cancellationToken: cancellationToken);
            await _libraryStaffBusinessRules.LibraryStaffShouldExistWhenSelected(libraryStaff);

            GetByIdLibraryStaffResponse response = _mapper.Map<GetByIdLibraryStaffResponse>(libraryStaff);
            return response;
        }
    }
}