using Application.Features.FineDues.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.FineDues.Rules;

public class FineDueBusinessRules : BaseBusinessRules
{
    private readonly IFineDueRepository _fineDueRepository;
    private readonly ILocalizationService _localizationService;

    public FineDueBusinessRules(IFineDueRepository fineDueRepository, ILocalizationService localizationService)
    {
        _fineDueRepository = fineDueRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, FineDuesBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task FineDueShouldExistWhenSelected(FineDue? fineDue)
    {
        if (fineDue == null)
            await throwBusinessException(FineDuesBusinessMessages.FineDueNotExists);
    }

    public async Task FineDueIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        FineDue? fineDue = await _fineDueRepository.GetAsync(
            predicate: fd => fd.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await FineDueShouldExistWhenSelected(fineDue);
    }

    //todo: BusinessRules -> Gecikme �cretleri: Kullan�c�lar�n kitaplar� belirlenen iade tarihinden sonra geri getirmeleri durumunda gecikme �cretleri uygulanabilir. Bu �cretler genellikle g�nl�k veya haftal�k bir �cret �zerinden hesaplan�r ve kitab�n iade tarihine kadar olan gecikme s�resine g�re de�i�ebilir.

    //todo: BusinessRules -> Gecikme Bildirimleri: Kullan�c�lara iade tarihine yakla�t�klar�nda ve gecikme durumunda hat�rlat�c� bildirimler g�nderilmelidir. Bu bildirimler, kullan�c�lar�n gecikme �cretlerinden ka��nmalar�na yard�mc� olabilir.

    //todo: BusinessRules -> Maksimum Gecikme S�resi: Kullan�c�lar i�in belirli bir gecikme s�resi belirlenebilir. Bu s�reden sonra, kitab�n iadesi i�in bir hat�rlatma g�nderilir ve belirli bir s�re i�inde iade edilmezse, daha y�ksek bir ceza uygulanabilir veya kitab�n maliyeti kullan�c�ya faturaland�r�labilir.

    //todo: BusinessRules -> Kay�p veya Hasarl� Kitaplar: Kullan�c�lar kaybolan veya hasar g�ren kitaplar i�in bir tazminat �demek zorundad�r. Tazminat miktar�, kaybolan veya hasar g�ren kitab�n de�erine ve onar�m maliyetine g�re belirlenebilir.

    //todo: BusinessRules -> �ade Edilmeyen Kitaplar: Kullan�c�lar belirli bir s�re i�inde kitaplar� iade etmezlerse, kitab�n fiyat� veya tazminat �creti kullan�c�ya faturaland�r�labilir. Bu, kay�p kitaplar�n k�t�phane koleksiyonuna yeniden eklenmesini sa�lar.
}