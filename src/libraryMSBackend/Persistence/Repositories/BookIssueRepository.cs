using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookIssueRepository : EfRepositoryBase<BookIssue, Guid, BaseDbContext>, IBookIssueRepository
{
    public BookIssueRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<int> GetBookCountByMemberIdAsync(Guid memberId)
    {
        // Üyenin sahip olduðu kitaplarýn sayýsýný döndür
        return await Context.Set<BookIssue>()
                             .CountAsync(b => b.MemberId == memberId);  
    }
}