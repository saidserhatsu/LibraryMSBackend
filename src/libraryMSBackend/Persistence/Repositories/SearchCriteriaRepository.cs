using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class SearchCriteriaRepository : EfRepositoryBase<SearchCriteria, Guid, BaseDbContext>, ISearchCriteriaRepository
{
    public SearchCriteriaRepository(BaseDbContext context) : base(context)
    {
    }
}