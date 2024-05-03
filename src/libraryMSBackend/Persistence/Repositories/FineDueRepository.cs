using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FineDueRepository : EfRepositoryBase<FineDue, Guid, BaseDbContext>, IFineDueRepository
{
    public FineDueRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<FineDue> FineDues => Context.Set<FineDue>(); // DbSet eri�imi

    public IQueryable<FineDue> Table => FineDues.AsQueryable(); // IQueryable eri�imi
}