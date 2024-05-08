using Application.Features.FinePayments.Constants;
using Application.Features.FinePayments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.FinePayments.Constants.FinePaymentsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.FinePayments.Queries.GetById;

public class GetByIdFinePaymentQuery : IRequest<GetByIdFinePaymentResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdFinePaymentQueryHandler : IRequestHandler<GetByIdFinePaymentQuery, GetByIdFinePaymentResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly FinePaymentBusinessRules _finePaymentBusinessRules;

        public GetByIdFinePaymentQueryHandler(IMapper mapper, IFinePaymentRepository finePaymentRepository, FinePaymentBusinessRules finePaymentBusinessRules)
        {
            _mapper = mapper;
            _finePaymentRepository = finePaymentRepository;
            _finePaymentBusinessRules = finePaymentBusinessRules;
        }

        public async Task<GetByIdFinePaymentResponse> Handle(GetByIdFinePaymentQuery request, CancellationToken cancellationToken)
        {
            FinePayment? finePayment = await _finePaymentRepository.GetAsync(
                 include: fp => fp.Include(fp => fp.Member),
                predicate: fp => fp.Id == request.Id, cancellationToken: cancellationToken
                );
            await _finePaymentBusinessRules.FinePaymentShouldExistWhenSelected(finePayment);

            GetByIdFinePaymentResponse response = _mapper.Map<GetByIdFinePaymentResponse>(finePayment);
            return response;
        }
    }
}