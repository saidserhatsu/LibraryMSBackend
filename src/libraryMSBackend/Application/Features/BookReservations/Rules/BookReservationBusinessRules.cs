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
}