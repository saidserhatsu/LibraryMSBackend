using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookIssues;

public interface IBookIssueService
{
    Task<BookIssue?> GetAsync(
        Expression<Func<BookIssue, bool>> predicate,
        Func<IQueryable<BookIssue>, IIncludableQueryable<BookIssue, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<BookIssue>?> GetListAsync(
        Expression<Func<BookIssue, bool>>? predicate = null,
        Func<IQueryable<BookIssue>, IOrderedQueryable<BookIssue>>? orderBy = null,
        Func<IQueryable<BookIssue>, IIncludableQueryable<BookIssue, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<BookIssue> AddAsync(BookIssue bookIssue);
    Task<BookIssue> UpdateAsync(BookIssue bookIssue);
    Task<BookIssue> DeleteAsync(BookIssue bookIssue, bool permanent = false);
}
