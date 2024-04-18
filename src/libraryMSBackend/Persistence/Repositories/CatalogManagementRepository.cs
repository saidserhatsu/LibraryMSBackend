using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CatalogManagementRepository : EfRepositoryBase<CatalogManagement, Guid, BaseDbContext>, ICatalogManagementRepository
{
    public CatalogManagementRepository(BaseDbContext context) : base(context)
    {
    }
}