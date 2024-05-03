using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class EBookRepository : EfRepositoryBase<EBook, Guid, BaseDbContext>, IEBookRepository
{
    public EBookRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<EBook> EBooks => Context.Set<EBook>(); // DbSet eriþimi

    public IQueryable<EBook> Table => EBooks.AsQueryable(); // IQueryable eriþimi
}