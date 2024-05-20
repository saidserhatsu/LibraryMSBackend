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
    private DbSet<BookIssue> BookIssues => Context.Set<BookIssue>(); // DbSet eri�imi

    public IQueryable<BookIssue> Table => BookIssues.AsQueryable(); // IQueryable eri�imi
    public async Task<int> GetBookCountByMemberIdAsync(Guid memberId)
    {
        // �yenin sahip oldu�u kitaplar�n say�s�n� d�nd�r
        return await Context.Set<BookIssue>()
                             .CountAsync(b => b.MemberId == memberId);  
    }
    public async Task<List<BookIssue>> GetOverdueBookIssuesAsync()
    {
        return await Context.Set<BookIssue>().Where(b => b.ReturnDate < DateTime.Now).ToListAsync();
    }
}