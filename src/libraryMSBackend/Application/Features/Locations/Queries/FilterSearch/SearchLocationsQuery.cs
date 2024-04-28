using Application.Features.Locations.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Locations.Queries.FilterSearch;
public class SearchLocationsQuery : IRequest<GetListResponse<GetListLocationListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchLocationsQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}
public class SearchLocationsQueryHandler : IRequestHandler<SearchLocationsQuery, GetListResponse<GetListLocationListItemDto>>
{
    private readonly ILocationRepository _locationRepository;
    private readonly IMapper _mapper;

    public SearchLocationsQueryHandler(ILocationRepository locationRepository, IMapper mapper)
    {
        _locationRepository = locationRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListLocationListItemDto>> Handle(SearchLocationsQuery request, CancellationToken cancellationToken)
    {
        var query = _locationRepository.Table;

        // LocationsName'e göre arama
        if (!string.IsNullOrEmpty(request.Criteria.LocationsName))
        {
            query = query.Where(l => l.Name.Contains(request.Criteria.LocationsName));
        }

        // LocationsShelfName'e göre arama
        if (!string.IsNullOrEmpty(request.Criteria.LocationsShelfName))
        {
            query = query.Where(l => l.ShelfName.Contains(request.Criteria.LocationsShelfName));
        }

        // Sayfalama
        IPaginate<Location> paginatedQuery = await query.ToPaginateAsync(
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Yanıtı oluşturmak için verileri mapleme
        var response = _mapper.Map<GetListResponse<GetListLocationListItemDto>>(paginatedQuery);
        return response;
    }
}
