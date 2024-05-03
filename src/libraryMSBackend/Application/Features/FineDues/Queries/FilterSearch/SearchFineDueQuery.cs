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

namespace Application.Features.FineDues.Queries.FilterSearch
{
    public class SearchFineDueQuery : IRequest<GetListResponse<SearchFineDueResponse>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchFineDueQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchFineDueQueryHandler : IRequestHandler<SearchFineDueQuery, GetListResponse<SearchFineDueResponse>>
    {
        private readonly IFineDueRepository _fineDueRepository; // FineDue repository
        private readonly IMapper _mapper;

        public SearchFineDueQueryHandler(IFineDueRepository fineDueRepository, IMapper mapper)
        {
            _fineDueRepository = fineDueRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<SearchFineDueResponse>> Handle(SearchFineDueQuery request, CancellationToken cancellationToken)
        {
            var query = _fineDueRepository.Table; // FineDue tablosundan veri çekin
            query = query.Include(f => f.BookIssue).ThenInclude(f=>f.Member)
                .Include(f=>f.BookIssue).ThenInclude(f=>f.Book); // İlişkili Member bilgilerini dahil edin

            if (!string.IsNullOrEmpty(request.Criteria.MemberFirstName))
            {
                query = query.Where(f => f.BookIssue.Member.FirstName.Contains(request.Criteria.MemberFirstName));
            }

            if (!string.IsNullOrEmpty(request.Criteria.MemberLastName))
            {
                query = query.Where(f => f.BookIssue.Member.LastName.Contains(request.Criteria.MemberLastName));
            }

            // Sayfalama işlemi
            IPaginate<FineDue> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize,
                cancellationToken:cancellationToken
            );

            // Map ve yanıt oluştur
            var response = _mapper.Map<GetListResponse<SearchFineDueResponse>>(paginatedQuery);
            return response;
        }
    }
}