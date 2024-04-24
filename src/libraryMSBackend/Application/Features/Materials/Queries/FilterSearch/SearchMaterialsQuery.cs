using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Services.Repositories;
using AutoMapper;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using Application.Features.Materials.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;

namespace Application.Features.Materials.Queries.FilterSearch
{
    public class SearchMaterialsQuery : IRequest<GetListResponse<GetListMaterialListItemDto>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchMaterialsQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchMaterialsQueryHandler : IRequestHandler<SearchMaterialsQuery, GetListResponse<GetListMaterialListItemDto>>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public SearchMaterialsQueryHandler(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMaterialListItemDto>> Handle(SearchMaterialsQuery request, CancellationToken cancellationToken)
        {
            var query = _materialRepository.Table;

            // Material Name'a göre filtreleme
            if (!string.IsNullOrEmpty(request.Criteria.MaterialName))
            {
                query = query.Where(m => m.Name.Contains(request.Criteria.MaterialName));
            }

            // Sorguyu sayfalama
            IPaginate<Material> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize
               
            );

            // Mapleme ve yanıt oluşturma
            GetListResponse<GetListMaterialListItemDto> response = _mapper.Map<GetListResponse<GetListMaterialListItemDto>>(paginatedQuery);
            return response;
        }
    }
}
