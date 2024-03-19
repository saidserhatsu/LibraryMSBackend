using Application.Features.BookReservations.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookReservations;

public class BookReservationManager : IBookReservationService
{
    private readonly IBookReservationRepository _bookReservationRepository;
    private readonly BookReservationBusinessRules _bookReservationBusinessRules;

    public BookReservationManager(IBookReservationRepository bookReservationRepository, BookReservationBusinessRules bookReservationBusinessRules)
    {
        _bookReservationRepository = bookReservationRepository;
        _bookReservationBusinessRules = bookReservationBusinessRules;
    }

    public async Task<BookReservation?> GetAsync(
        Expression<Func<BookReservation, bool>> predicate,
        Func<IQueryable<BookReservation>, IIncludableQueryable<BookReservation, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        BookReservation? bookReservation = await _bookReservationRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return bookReservation;
    }

    public async Task<IPaginate<BookReservation>?> GetListAsync(
        Expression<Func<BookReservation, bool>>? predicate = null,
        Func<IQueryable<BookReservation>, IOrderedQueryable<BookReservation>>? orderBy = null,
        Func<IQueryable<BookReservation>, IIncludableQueryable<BookReservation, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<BookReservation> bookReservationList = await _bookReservationRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return bookReservationList;
    }

    public async Task<BookReservation> AddAsync(BookReservation bookReservation)
    {
        BookReservation addedBookReservation = await _bookReservationRepository.AddAsync(bookReservation);

        return addedBookReservation;
    }

    public async Task<BookReservation> UpdateAsync(BookReservation bookReservation)
    {
        BookReservation updatedBookReservation = await _bookReservationRepository.UpdateAsync(bookReservation);

        return updatedBookReservation;
    }

    public async Task<BookReservation> DeleteAsync(BookReservation bookReservation, bool permanent = false)
    {
        BookReservation deletedBookReservation = await _bookReservationRepository.DeleteAsync(bookReservation);

        return deletedBookReservation;
    }
}
