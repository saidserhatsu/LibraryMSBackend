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
    private DbSet<BookIssue> BookIssues => Context.Set<BookIssue>(); // DbSet eriþimi

    public IQueryable<BookIssue> Table => BookIssues.AsQueryable(); // IQueryable eriþimi
    public async Task<int> GetBookCountByMemberIdAsync(Guid memberId)
    {
        // Üyenin sahip olduðu kitaplarýn sayýsýný döndür
        return await Context.Set<BookIssue>()
                             .CountAsync(b => b.MemberId == memberId);  
    }
    public async Task<List<BookIssue>> GetOverdueBookIssuesAsync()
    {
        return await Context.Set<BookIssue>().Where(b => b.ReturnDate < DateTime.Now).ToListAsync();
    }
}