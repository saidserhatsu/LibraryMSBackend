using Application.Features.FinePayments.Constants;
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

namespace Application.Features.FinePayments.Commands.Delete;

public class DeleteFinePaymentCommand : IRequest<DeletedFinePaymentResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, FinePaymentsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFinePayments"];

    public class DeleteFinePaymentCommandHandler : IRequestHandler<DeleteFinePaymentCommand, DeletedFinePaymentResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFinePaymentRepository _finePaymentRepository;
        private readonly FinePaymentBusinessRules _finePaymentBusinessRules;

        public DeleteFinePaymentCommandHandler(IMapper mapper, IFinePaymentRepository finePaymentRepository,
                                         FinePaymentBusinessRules finePaymentBusinessRules)
        {
            _mapper = mapper;
            _finePaymentRepository = finePaymentRepository;
            _finePaymentBusinessRules = finePaymentBusinessRules;
        }

        public async Task<DeletedFinePaymentResponse> Handle(DeleteFinePaymentCommand request, CancellationToken cancellationToken)
        {
            FinePayment? finePayment = await _finePaymentRepository.GetAsync(predicate: fp => fp.Id == request.Id, cancellationToken: cancellationToken);
            await _finePaymentBusinessRules.FinePaymentShouldExistWhenSelected(finePayment);

            await _finePaymentRepository.DeleteAsync(finePayment!);

            DeletedFinePaymentResponse response = _mapper.Map<DeletedFinePaymentResponse>(finePayment);
            return response;
        }
    }
}