using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICategoryRepository : IAsyncRepository<Category, int>, IRepository<Category, int>
{
    IQueryable<Category> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
}