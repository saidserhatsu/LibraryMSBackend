using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.MagazineAuthors;

public interface IMagazineAuthorService
{
    Task<MagazineAuthor?> GetAsync(
        Expression<Func<MagazineAuthor, bool>> predicate,
        Func<IQueryable<MagazineAuthor>, IIncludableQueryable<MagazineAuthor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<MagazineAuthor>?> GetListAsync(
        Expression<Func<MagazineAuthor, bool>>? predicate = null,
        Func<IQueryable<MagazineAuthor>, IOrderedQueryable<MagazineAuthor>>? orderBy = null,
        Func<IQueryable<MagazineAuthor>, IIncludableQueryable<MagazineAuthor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<MagazineAuthor> AddAsync(MagazineAuthor magazineAuthor);
    Task<MagazineAuthor> UpdateAsync(MagazineAuthor magazineAuthor);
    Task<MagazineAuthor> DeleteAsync(MagazineAuthor magazineAuthor, bool permanent = false);
}
