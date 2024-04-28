using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class MemberRepository : EfRepositoryBase<Member, Guid, BaseDbContext>, IMemberRepository
{
    public MemberRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<Member> Members => Context.Set<Member>(); // DbSet eriþimi

    public IQueryable<Member> Table => Members.AsQueryable(); // IQueryable eriþimi
}