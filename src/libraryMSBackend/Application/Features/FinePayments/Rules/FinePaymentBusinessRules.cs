using Application.Features.FinePayments.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.FinePayments.Rules;

public class FinePaymentBusinessRules : BaseBusinessRules
{
    private readonly IFinePaymentRepository _finePaymentRepository;
    private readonly ILocalizationService _localizationService;

    public FinePaymentBusinessRules(IFinePaymentRepository finePaymentRepository, ILocalizationService localizationService)
    {
        _finePaymentRepository = finePaymentRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, FinePaymentsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task FinePaymentShouldExistWhenSelected(FinePayment? finePayment)
    {
        if (finePayment == null)
            await throwBusinessException(FinePaymentsBusinessMessages.FinePaymentNotExists);
    }

    public async Task FinePaymentIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        FinePayment? finePayment = await _finePaymentRepository.GetAsync(
            predicate: fp => fp.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await FinePaymentShouldExistWhenSelected(finePayment);
    }
}