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

    //todo: BusinessRules -> Gecikme Ücretleri: Kullanýcýlarýn kitaplarý belirlenen iade tarihinden sonra geri getirmeleri durumunda gecikme ücretleri uygulanabilir. Bu ücretler genellikle günlük veya haftalýk bir ücret üzerinden hesaplanýr ve kitabýn iade tarihine kadar olan gecikme süresine göre deðiþebilir.

    //todo: BusinessRules -> Gecikme Bildirimleri: Kullanýcýlara iade tarihine yaklaþtýklarýnda ve gecikme durumunda hatýrlatýcý bildirimler gönderilmelidir. Bu bildirimler, kullanýcýlarýn gecikme ücretlerinden kaçýnmalarýna yardýmcý olabilir.

    //todo: BusinessRules -> Maksimum Gecikme Süresi: Kullanýcýlar için belirli bir gecikme süresi belirlenebilir. Bu süreden sonra, kitabýn iadesi için bir hatýrlatma gönderilir ve belirli bir süre içinde iade edilmezse, daha yüksek bir ceza uygulanabilir veya kitabýn maliyeti kullanýcýya faturalandýrýlabilir.

    //todo: BusinessRules -> Kayýp veya Hasarlý Kitaplar: Kullanýcýlar kaybolan veya hasar gören kitaplar için bir tazminat ödemek zorundadýr. Tazminat miktarý, kaybolan veya hasar gören kitabýn deðerine ve onarým maliyetine göre belirlenebilir.

    //todo: BusinessRules -> Ýade Edilmeyen Kitaplar: Kullanýcýlar belirli bir süre içinde kitaplarý iade etmezlerse, kitabýn fiyatý veya tazminat ücreti kullanýcýya faturalandýrýlabilir. Bu, kayýp kitaplarýn kütüphane koleksiyonuna yeniden eklenmesini saðlar.
}