using Application.Features.SearchCriterias.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.SearchCriterias.Constants.SearchCriteriasOperationClaims;

namespace Application.Features.SearchCriterias.Queries.GetList;

public class GetListSearchCriteriaQuery : IRequest<GetListResponse<GetListSearchCriteriaListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListSearchCriterias({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetSearchCriterias";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListSearchCriteriaQueryHandler : IRequestHandler<GetListSearchCriteriaQuery, GetListResponse<GetListSearchCriteriaListItemDto>>
    {
        private readonly ISearchCriteriaRepository _searchCriteriaRepository;
        private readonly IMapper _mapper;

        public GetListSearchCriteriaQueryHandler(ISearchCriteriaRepository searchCriteriaRepository, IMapper mapper)
        {
            _searchCriteriaRepository = searchCriteriaRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListSearchCriteriaListItemDto>> Handle(GetListSearchCriteriaQuery request, CancellationToken cancellationToken)
        {
            IPaginate<SearchCriteria> searchCriterias = await _searchCriteriaRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListSearchCriteriaListItemDto> response = _mapper.Map<GetListResponse<GetListSearchCriteriaListItemDto>>(searchCriterias);
            return response;
        }
    }
}