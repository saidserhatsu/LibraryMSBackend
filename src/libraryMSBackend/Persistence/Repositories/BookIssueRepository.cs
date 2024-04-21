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
        // �yenin sahip oldu�u kitaplar�n say�s�n� d�nd�r
        return await Context.Set<BookIssue>()
                             .CountAsync(b => b.MemberId == memberId);  
    }
}