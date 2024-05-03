using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Application.Services.Repositories;
using Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Books.Queries.FilterSearch;

namespace Application.Features.EBooks.Queries.FilterSearch
{
    public class SearchEBookQuery : MediatR.IRequest<GetListResponse<SearchEbookResponse>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchEBookQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchEBookQueryHandler : IRequestHandler<SearchEBookQuery, GetListResponse<SearchEbookResponse>>
    {
        private readonly IEBookRepository _eBookRepository;
        private readonly IMapper _mapper;

        public SearchEBookQueryHandler(IEBookRepository eBookRepository, IMapper mapper)
        {
            _eBookRepository = eBookRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<SearchEbookResponse>> Handle(SearchEBookQuery request, CancellationToken cancellationToken)
        {
            var query = _eBookRepository.Table;
            query = query.Include(b => b.Category);

            // Arama kriterlerine göre filtreleme
            if (!string.IsNullOrEmpty(request.Criteria.EBookTitle))
            {
                query = query.Where(e => e.EBookTitle.Contains(request.Criteria.EBookTitle));
            }
            if (!string.IsNullOrEmpty(request.Criteria.EBookISBNCode))
            {
                query = query.Where(e => e.ISBNCode.Contains(request.Criteria.EBookISBNCode));
            }
            if (!string.IsNullOrEmpty(request.Criteria.EBookAuthorName))
            {
                query = query.Where(e => e.AuthorName.Contains(request.Criteria.EBookAuthorName));
            }

            // Sayfalama ve sonuç döndürme
            IPaginate<EBook> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize,
            cancellationToken:cancellationToken
            );

            var response = _mapper.Map<GetListResponse<SearchEbookResponse>>(paginatedQuery);
            return response;
        }
    }
}