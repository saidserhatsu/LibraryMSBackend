using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IBookIssueRepository : IAsyncRepository<BookIssue, Guid>, IRepository<BookIssue, Guid>
{
    IQueryable<BookIssue> Table { get; } // Bu �zellik, IQueryable eri�imini sa�lar.
    Task<int> GetBookCountByMemberIdAsync(Guid memberId);
}