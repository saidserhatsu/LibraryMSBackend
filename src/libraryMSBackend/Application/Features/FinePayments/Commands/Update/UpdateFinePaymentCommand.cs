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

namespace Application.Features.FinePayments.Commands.Update;

public class UpdateFinePaymentCommand : IRequest<UpdatedFinePaymentResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }

    public string[] Roles => [Admin, Write, FinePaymentsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFinePayments"];

    public class UpdateFinePaymentCommandHandler : IRequestHandler<UpdateFinePaymentCommand, UpdatedFinePaymentResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly FinePaymentBusinessRules _finePaymentBusinessRules;

        public UpdateFinePaymentCommandHandler(IMapper mapper, IFinePaymentRepository finePaymentRepository,
                                         FinePaymentBusinessRules finePaymentBusinessRules)
        {
            _mapper = mapper;
            _finePaymentRepository = finePaymentRepository;
            _finePaymentBusinessRules = finePaymentBusinessRules;
        }

        public async Task<UpdatedFinePaymentResponse> Handle(UpdateFinePaymentCommand request, CancellationToken cancellationToken)
        {
            FinePayment? finePayment = await _finePaymentRepository.GetAsync(predicate: fp => fp.Id == request.Id, cancellationToken: cancellationToken);
            await _finePaymentBusinessRules.FinePaymentShouldExistWhenSelected(finePayment);
            finePayment = _mapper.Map(request, finePayment);

            await _finePaymentRepository.UpdateAsync(finePayment!);

            UpdatedFinePaymentResponse response = _mapper.Map<UpdatedFinePaymentResponse>(finePayment);
            return response;
        }
    }
}