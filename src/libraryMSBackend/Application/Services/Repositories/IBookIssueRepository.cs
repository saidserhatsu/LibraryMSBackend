using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IBookIssueRepository : IAsyncRepository<BookIssue, Guid>, IRepository<BookIssue, Guid>
{
    IQueryable<BookIssue> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
    Task<int> GetBookCountByMemberIdAsync(Guid memberId);
}