using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ISearchCriteriaRepository : IAsyncRepository<SearchCriteria, Guid>, IRepository<SearchCriteria, Guid>
{
}