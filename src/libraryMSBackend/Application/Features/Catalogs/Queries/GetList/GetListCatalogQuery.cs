using Application.Features.Catalogs.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Catalogs.Constants.CatalogsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Catalogs.Queries.GetList;

public class GetListCatalogQuery : IRequest<GetListResponse<GetListCatalogListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListCatalogs({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetCatalogs";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListCatalogQueryHandler : IRequestHandler<GetListCatalogQuery, GetListResponse<GetListCatalogListItemDto>>
    {
        private readonly ICatalogRepository _catalogRepository;
        private readonly IMapper _mapper;

        public GetListCatalogQueryHandler(ICatalogRepository catalogRepository, IMapper mapper)
        {
            _catalogRepository = catalogRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCatalogListItemDto>> Handle(GetListCatalogQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Catalog> catalogs = await _catalogRepository.GetListAsync(
                include: cm => cm.Include(cm=>cm.CatalogManagements).ThenInclude(cm=>cm.Book).ThenInclude(cm => cm.BookAuthors).ThenInclude(cm => cm.Author)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Magazine)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Material),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCatalogListItemDto> response = _mapper.Map<GetListResponse<GetListCatalogListItemDto>>(catalogs);
            return response;
        }
    }
}