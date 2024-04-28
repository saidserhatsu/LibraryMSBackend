using Application.Features.Publishers.Queries.GetList;
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

namespace Application.Features.Publishers.Queries.FilterSearch;
public class SearchPublishersQuery : IRequest<GetListResponse<GetListPublisherListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchPublishersQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}
public class SearchPublishersQueryHandler : IRequestHandler<SearchPublishersQuery, GetListResponse<GetListPublisherListItemDto>>
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly IMapper _mapper;

    public SearchPublishersQueryHandler(IPublisherRepository publisherRepository, IMapper mapper)
    {
        _publisherRepository = publisherRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListPublisherListItemDto>> Handle(SearchPublishersQuery request, CancellationToken cancellationToken)
    {
        var query = _publisherRepository.Table;

        // Publisher Name'e göre arama
        if (!string.IsNullOrEmpty(request.Criteria.PublisherName))
        {
            query = query.Where(p => p.Name.Contains(request.Criteria.PublisherName));
        }

        // Publisher Language'e göre arama
        if (!string.IsNullOrEmpty(request.Criteria.PublisherLanguage))
        {
            query = query.Where(p => p.Language.Contains(request.Criteria.PublisherLanguage));
        }

        // Sayfalama
        IPaginate<Publisher> paginatedQuery = await query.ToPaginateAsync(
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Yanıtı oluşturmak için verileri haritalama
        var response = _mapper.Map<GetListResponse<GetListPublisherListItemDto>>(paginatedQuery);
        return response;
    }
}