using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PublisherRepository : EfRepositoryBase<Publisher, Guid, BaseDbContext>, IPublisherRepository
{
    public PublisherRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<Publisher> Publishers => Context.Set<Publisher>(); // DbSet eriþimi

    public IQueryable<Publisher> Table => Publishers.AsQueryable(); // IQueryable eriþimi
}