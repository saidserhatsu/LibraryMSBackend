using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICatalogManagementRepository : IAsyncRepository<CatalogManagement, Guid>, IRepository<CatalogManagement, Guid>
{
}