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

    //todo: BusinessRules -> �deme Onay� ve Kay�t: Kullan�c�n�n �demesi yap�ld�ktan sonra sistemde bu �demenin do�rulanmas� ve kaydedilmesi gerekir. Bu i�lem, kullan�c�n�n �demesinin ba�ar�yla tamamland���ndan emin olmak i�in �nemlidir.

    //todo: BusinessRules -> �deme Bildirimi: Kullan�c�ya �demenin ba�ar�yla al�nd���na dair bir bildirim g�nderilmesi gerekir. Bu bildirim, kullan�c�n�n �demenin tamamland���na dair bir onay almas�n� sa�lar ve i�lem hakk�nda bilgilendirir.

    //todo: BusinessRules -> �deme Ge�mi�i: Kullan�c�lar�n �deme ge�mi�i tutulmal�. Bu, kullan�c�lar�n �deme ge�mi�lerini izlemelerine ve gerekti�inde �deme yapmalar�na yard�mc� olur.
}