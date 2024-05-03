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
using Nest;

namespace Application.Features.FinePayments.Queries.FilterSearch
{
    public class SearchFinePaymentQuery : MediatR.IRequest<GetListResponse<SearchFinePaymentResponse>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchFinePaymentQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchFinePaymentQueryHandler : IRequestHandler<SearchFinePaymentQuery, GetListResponse<SearchFinePaymentResponse>>
    {
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly IMapper _mapper;

        public SearchFinePaymentQueryHandler(IFinePaymentRepository finePaymentRepository, IMapper mapper)
        {
            _finePaymentRepository = finePaymentRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<SearchFinePaymentResponse>> Handle(SearchFinePaymentQuery request, CancellationToken cancellationToken)
        {
            var query = _finePaymentRepository.Table;
            query = query.Include(b => b.Member);

            if (!string.IsNullOrEmpty(request.Criteria.MemberFirstName))
            {
                query = query.Where(m => m.Member.FirstName.Contains(request.Criteria.MemberFirstName));
            }
            if (!string.IsNullOrEmpty(request.Criteria.MemberLastName))
            {
                query = query.Where(m => m.Member.LastName.Contains(request.Criteria.MemberLastName));
            }


            IPaginate<FinePayment> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize
            );

            var response = _mapper.Map<GetListResponse<SearchFinePaymentResponse>>(paginatedQuery);
            return response;
        }
    }


}