using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FineDueRepository : EfRepositoryBase<FineDue, Guid, BaseDbContext>, IFineDueRepository
{
    public FineDueRepository(BaseDbContext context) : base(context)
    {
    }
}