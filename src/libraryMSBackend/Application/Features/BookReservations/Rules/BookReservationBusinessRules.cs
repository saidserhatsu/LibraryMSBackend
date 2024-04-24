using Application.Features.BookReservations.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.BookReservations.Rules;

public class BookReservationBusinessRules : BaseBusinessRules
{
    private readonly IBookReservationRepository _bookReservationRepository;
    private readonly ILocalizationService _localizationService;
    private readonly IBookRepository _bookRepository;

    public BookReservationBusinessRules(IBookReservationRepository bookReservationRepository, ILocalizationService localizationService, IBookRepository bookRepository)
    {
        _bookReservationRepository = bookReservationRepository;
        _localizationService = localizationService;
        _bookRepository = bookRepository;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, BookReservationsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task BookReservationShouldExistWhenSelected(BookReservation? bookReservation)
    {
        if (bookReservation == null)
            await throwBusinessException(BookReservationsBusinessMessages.BookReservationNotExists);
    }

    public async Task BookReservationIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        BookReservation? bookReservation = await _bookReservationRepository.GetAsync(
            predicate: br => br.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BookReservationShouldExistWhenSelected(bookReservation);
    }
    public async Task EnsureBookCanBeReserved(Guid bookId)
    {
        // Kitabý alýn
        var book = await _bookRepository.GetByIdAsync(bookId);

        // Eðer kitap rezerve edilmiþse, yeni rezervasyona izin verme
        var existingReservation = _bookReservationRepository.Table
            .FirstOrDefault(br => br.BookId == bookId);

        if (existingReservation != null)
        {
            throw new Exception($"This book is already reserved by another user.");
        }

        // Eðer kitap ödünç alýnmýþsa, rezervasyon yapýlabilir
        if (book.Status == BookStatus.Borrowed)
        {
            return; // Rezervasyon yapýlabilir
        }

        // Diðer durumlar için herhangi bir engel yoktur
    }

    //todo: BusinessRules -> Rezervasyon Süresi: Bir kullanýcýnýn bir kitabý ne kadar süreyle rezerve edebileceði belirlenmelidir. Örneðin, her kullanýcýya belirli bir süre için rezervasyon hakký verilebilir, bu süre genellikle birkaç gün ile bir hafta arasýnda olabilir.

    //todo: BusinessRules -> Rezervasyon Önceliði: Birden fazla kullanýcýnýn ayný kitabý rezerve etmek istemesi durumunda, rezervasyon önceliði belirli kurallara göre belirlenebilir. Örneðin, rezervasyonu ilk yapan kullanýcýya öncelik verilebilir veya daha önce rezervasyon yapmamýþ kullanýcýlara öncelik tanýnabilir.

    //todo: BusinessRules -> Rezervasyon Ýptali: Kullanýcýlarýn rezervasyonlarýný iptal edebilme hakký olmalýdýr. Ancak, iptal edilen rezervasyonlarýn belirli bir süre içinde (örneðin, 24 saat) geri alýnmasý gerekebilir, aksi takdirde kitap baþka bir kullanýcýya rezerve edilebilir.

    //todo: BusinessRules -> Rezervasyon Limiti: Bir kullanýcýnýn ayný anda kaç kitap rezerve edebileceði sýnýrlanabilir. Bu, ayný zamanda birden fazla kullanýcýnýn kütüphanenin belirli kitaplarýný ayný anda rezerve etmesini önleyebilir.

    //todo: BusinessRules -> Rezervasyon Bildirimi: Kullanýcýlara rezervasyonlarýnýn onaylandýðý veya reddedildiði konusunda bildirimler gönderilmelidir. Ayrýca, rezervasyonun sona ermesine yakýn kullanýcýlara hatýrlatýcý bildirimler göndermek de yararlý olabilir.
}