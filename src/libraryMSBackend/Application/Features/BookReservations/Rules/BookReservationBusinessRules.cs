using Application.Features.BookReservations.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.BookReservations.Rules;

public class BookReservationBusinessRules : BaseBusinessRules
{
    private readonly IBookReservationRepository _bookReservationRepository;
    private readonly ILocalizationService _localizationService;

    public BookReservationBusinessRules(IBookReservationRepository bookReservationRepository, ILocalizationService localizationService)
    {
        _bookReservationRepository = bookReservationRepository;
        _localizationService = localizationService;
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

    //todo: BusinessRules -> Rezervasyon S�resi: Bir kullan�c�n�n bir kitab� ne kadar s�reyle rezerve edebilece�i belirlenmelidir. �rne�in, her kullan�c�ya belirli bir s�re i�in rezervasyon hakk� verilebilir, bu s�re genellikle birka� g�n ile bir hafta aras�nda olabilir.

    //todo: BusinessRules -> Rezervasyon �nceli�i: Birden fazla kullan�c�n�n ayn� kitab� rezerve etmek istemesi durumunda, rezervasyon �nceli�i belirli kurallara g�re belirlenebilir. �rne�in, rezervasyonu ilk yapan kullan�c�ya �ncelik verilebilir veya daha �nce rezervasyon yapmam�� kullan�c�lara �ncelik tan�nabilir.

    //todo: BusinessRules -> Rezervasyon �ptali: Kullan�c�lar�n rezervasyonlar�n� iptal edebilme hakk� olmal�d�r. Ancak, iptal edilen rezervasyonlar�n belirli bir s�re i�inde (�rne�in, 24 saat) geri al�nmas� gerekebilir, aksi takdirde kitap ba�ka bir kullan�c�ya rezerve edilebilir.

    //todo: BusinessRules -> Rezervasyon Limiti: Bir kullan�c�n�n ayn� anda ka� kitap rezerve edebilece�i s�n�rlanabilir. Bu, ayn� zamanda birden fazla kullan�c�n�n k�t�phanenin belirli kitaplar�n� ayn� anda rezerve etmesini �nleyebilir.

    //todo: BusinessRules -> Rezervasyon Bildirimi: Kullan�c�lara rezervasyonlar�n�n onayland��� veya reddedildi�i konusunda bildirimler g�nderilmelidir. Ayr�ca, rezervasyonun sona ermesine yak�n kullan�c�lara hat�rlat�c� bildirimler g�ndermek de yararl� olabilir.
}