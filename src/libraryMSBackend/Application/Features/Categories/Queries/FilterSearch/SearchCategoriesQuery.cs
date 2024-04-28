using Application.Features.Categories.Queries.GetList;
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

namespace Application.Features.Categories.Queries.FilterSearch;
public class SearchCategoriesQuery : IRequest<GetListResponse<GetListCategoryListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchCategoriesQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}
public class SearchCategoriesQueryHandler : IRequestHandler<SearchCategoriesQuery, GetListResponse<GetListCategoryListItemDto>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public SearchCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListCategoryListItemDto>> Handle(SearchCategoriesQuery request, CancellationToken cancellationToken)
    {
        var query = _categoryRepository.Table;

        // Category Name'e göre arama
        if (!string.IsNullOrEmpty(request.Criteria.CategoryName))
        {
            query = query.Where(c => c.Name.Contains(request.Criteria.CategoryName));
        }

        // Sayfalama uygulama
        IPaginate<Category> paginatedQuery = await query.ToPaginateAsync(
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Yanıtı oluşturmak için verileri haritalama
        GetListResponse<GetListCategoryListItemDto> response = _mapper.Map<GetListResponse<GetListCategoryListItemDto>>(paginatedQuery);
        return response;
    }
}