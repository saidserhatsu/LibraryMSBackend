using Application.Features.FinePayments.Constants;
using Application.Features.FinePayments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.FinePayments.Constants.FinePaymentsOperationClaims;

namespace Application.Features.FinePayments.Commands.Create;

public class CreateFinePaymentCommand : IRequest<CreatedFinePaymentResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }

    public string[] Roles => [Admin, Write, FinePaymentsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFinePayments"];

    public class CreateFinePaymentCommandHandler : IRequestHandler<CreateFinePaymentCommand, CreatedFinePaymentResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly FinePaymentBusinessRules _finePaymentBusinessRules;

        public CreateFinePaymentCommandHandler(IMapper mapper, IFinePaymentRepository finePaymentRepository,
                                         FinePaymentBusinessRules finePaymentBusinessRules)
        {
            _mapper = mapper;
            _finePaymentRepository = finePaymentRepository;
            _finePaymentBusinessRules = finePaymentBusinessRules;
        }

        public async Task<CreatedFinePaymentResponse> Handle(CreateFinePaymentCommand request, CancellationToken cancellationToken)
        {
            FinePayment finePayment = _mapper.Map<FinePayment>(request);

            await _finePaymentRepository.AddAsync(finePayment);

            CreatedFinePaymentResponse response = _mapper.Map<CreatedFinePaymentResponse>(finePayment);
            return response;
        }
    }
}