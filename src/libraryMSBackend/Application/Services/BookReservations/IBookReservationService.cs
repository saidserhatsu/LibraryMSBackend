using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookReservations;

public interface IBookReservationService
{
    Task<BookReservation?> GetAsync(
        Expression<Func<BookReservation, bool>> predicate,
        Func<IQueryable<BookReservation>, IIncludableQueryable<BookReservation, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<BookReservation>?> GetListAsync(
        Expression<Func<BookReservation, bool>>? predicate = null,
        Func<IQueryable<BookReservation>, IOrderedQueryable<BookReservation>>? orderBy = null,
        Func<IQueryable<BookReservation>, IIncludableQueryable<BookReservation, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<BookReservation> AddAsync(BookReservation bookReservation);
    Task<BookReservation> UpdateAsync(BookReservation bookReservation);
    Task<BookReservation> DeleteAsync(BookReservation bookReservation, bool permanent = false);
}
