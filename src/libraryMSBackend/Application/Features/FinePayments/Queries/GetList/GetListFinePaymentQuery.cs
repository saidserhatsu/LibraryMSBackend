using Application.Features.FinePayments.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.FinePayments.Constants.FinePaymentsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.FinePayments.Queries.GetList;

public class GetListFinePaymentQuery : IRequest<GetListResponse<GetListFinePaymentListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListFinePayments({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetFinePayments";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListFinePaymentQueryHandler : IRequestHandler<GetListFinePaymentQuery, GetListResponse<GetListFinePaymentListItemDto>>
    {
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly IMapper _mapper;

        public GetListFinePaymentQueryHandler(IFinePaymentRepository finePaymentRepository, IMapper mapper)
        {
            _finePaymentRepository = finePaymentRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListFinePaymentListItemDto>> Handle(GetListFinePaymentQuery request, CancellationToken cancellationToken)
        {
            IPaginate<FinePayment> finePayments = await _finePaymentRepository.GetListAsync(
                include: fp => fp.Include(fp => fp.Member),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            ); 

            GetListResponse<GetListFinePaymentListItemDto> response = _mapper.Map<GetListResponse<GetListFinePaymentListItemDto>>(finePayments);
            return response;
        }
    }
}