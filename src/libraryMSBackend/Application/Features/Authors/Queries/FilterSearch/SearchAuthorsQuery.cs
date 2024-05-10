using Application.Features.Authors.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Authors.Queries.FilterSearch
{
    public class SearchAuthorsQuery : IRequest<GetListResponse<GetListAuthorListItemDto>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchAuthorsQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchAuthorsQueryHandler : IRequestHandler<SearchAuthorsQuery, GetListResponse<GetListAuthorListItemDto>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public SearchAuthorsQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListAuthorListItemDto>> Handle(SearchAuthorsQuery request, CancellationToken cancellationToken)
        {
            var query = _authorRepository.Table;

            // Author FirstName'e göre arama
            if (!string.IsNullOrEmpty(request.Criteria.AuthorName))
            {
                query = query.Where(a => a.FirstName.Contains(request.Criteria.AuthorName));
            }

            // Author LastName'e göre arama
            if (!string.IsNullOrEmpty(request.Criteria.AuthorSurname))
            {
                query = query.Where(a => a.LastName.Contains(request.Criteria.AuthorSurname));
            }

            // Sayfalama uygulama
            IPaginate<Author> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize
            );

            // Yanıtı oluşturmak için verileri haritalama
            GetListResponse<GetListAuthorListItemDto> response = _mapper.Map<GetListResponse<GetListAuthorListItemDto>>(paginatedQuery);
            return response;
        }
    }
}