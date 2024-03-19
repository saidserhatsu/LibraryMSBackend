using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookAuthors;

public interface IBookAuthorService
{
    Task<BookAuthor?> GetAsync(
        Expression<Func<BookAuthor, bool>> predicate,
        Func<IQueryable<BookAuthor>, IIncludableQueryable<BookAuthor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<BookAuthor>?> GetListAsync(
        Expression<Func<BookAuthor, bool>>? predicate = null,
        Func<IQueryable<BookAuthor>, IOrderedQueryable<BookAuthor>>? orderBy = null,
        Func<IQueryable<BookAuthor>, IIncludableQueryable<BookAuthor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<BookAuthor> AddAsync(BookAuthor bookAuthor);
    Task<BookAuthor> UpdateAsync(BookAuthor bookAuthor);
    Task<BookAuthor> DeleteAsync(BookAuthor bookAuthor, bool permanent = false);
}
