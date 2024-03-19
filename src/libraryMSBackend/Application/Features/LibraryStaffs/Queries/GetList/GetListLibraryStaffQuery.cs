using Application.Features.LibraryStaffs.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.LibraryStaffs.Constants.LibraryStaffsOperationClaims;

namespace Application.Features.LibraryStaffs.Queries.GetList;

public class GetListLibraryStaffQuery : IRequest<GetListResponse<GetListLibraryStaffListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListLibraryStaffs({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetLibraryStaffs";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListLibraryStaffQueryHandler : IRequestHandler<GetListLibraryStaffQuery, GetListResponse<GetListLibraryStaffListItemDto>>
    {
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly IMapper _mapper;

        public GetListLibraryStaffQueryHandler(ILibraryStaffRepository libraryStaffRepository, IMapper mapper)
        {
            _libraryStaffRepository = libraryStaffRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListLibraryStaffListItemDto>> Handle(GetListLibraryStaffQuery request, CancellationToken cancellationToken)
        {
            IPaginate<LibraryStaff> libraryStaffs = await _libraryStaffRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListLibraryStaffListItemDto> response = _mapper.Map<GetListResponse<GetListLibraryStaffListItemDto>>(libraryStaffs);
            return response;
        }
    }
}