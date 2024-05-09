using Application.Features.Catalogs.Queries.GetList;
using Application.Features.Categories.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Catalogs.Queries.FilterSearch
{
    public class SearchCatalogsQuery : IRequest<GetListResponse<GetListCatalogListItemDto>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchCatalogsQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchCatalogsQueryHandler : IRequestHandler<SearchCatalogsQuery, GetListResponse<GetListCatalogListItemDto>>
    {
        private readonly ICatalogRepository _catalogRepository;
        private readonly IMapper _mapper;

        public SearchCatalogsQueryHandler(ICatalogRepository catalogRepository, IMapper mapper)
        {
            _catalogRepository = catalogRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCatalogListItemDto>> Handle(SearchCatalogsQuery request, CancellationToken cancellationToken)
        {
            var query = _catalogRepository.Table;
            query = query.Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.BookAuthors).ThenInclude(cm => cm.Author)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Magazine)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Material)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Category)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Publisher)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Location);

            // Katalog adına göre arama
            if (!string.IsNullOrEmpty(request.Criteria.CatalogName))
            {
                query = query.Where(c => c.Name.Contains(request.Criteria.CatalogName));
            }

            // Sayfalama uygulama
            IPaginate<Catalog> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize
            );

            // Yanıtı oluşturmak için verileri haritalama


            GetListResponse<GetListCatalogListItemDto> response = _mapper.Map<GetListResponse<GetListCatalogListItemDto>>(paginatedQuery);
            return response;
           
        }
    }
}