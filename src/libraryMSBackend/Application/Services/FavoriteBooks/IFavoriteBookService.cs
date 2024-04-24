using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FavoriteBooks;

public interface IFavoriteBookService
{
    Task<FavoriteBook?> GetAsync(
        Expression<Func<FavoriteBook, bool>> predicate,
        Func<IQueryable<FavoriteBook>, IIncludableQueryable<FavoriteBook, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<FavoriteBook>?> GetListAsync(
        Expression<Func<FavoriteBook, bool>>? predicate = null,
        Func<IQueryable<FavoriteBook>, IOrderedQueryable<FavoriteBook>>? orderBy = null,
        Func<IQueryable<FavoriteBook>, IIncludableQueryable<FavoriteBook, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<FavoriteBook> AddAsync(FavoriteBook favoriteBook);
    Task<FavoriteBook> UpdateAsync(FavoriteBook favoriteBook);
    Task<FavoriteBook> DeleteAsync(FavoriteBook favoriteBook, bool permanent = false);
}
