using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class AuthorRepository : EfRepositoryBase<Author, Guid, BaseDbContext>, IAuthorRepository
{
    public AuthorRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<Author> Authors => Context.Set<Author>(); // DbSet eriþimi

    public IQueryable<Author> Table => Authors.AsQueryable(); // IQueryable eriþimi


}