using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CategoryRepository : EfRepositoryBase<Category, int, BaseDbContext>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context) : base(context)
    {
    }

    private DbSet<Category> Categories => Context.Set<Category>(); // DbSet eriþimi

    public IQueryable<Category> Table => Categories.AsQueryable(); // IQueryable eriþimi
}