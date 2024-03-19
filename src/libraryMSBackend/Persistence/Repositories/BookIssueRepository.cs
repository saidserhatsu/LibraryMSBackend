using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookIssueRepository : EfRepositoryBase<BookIssue, Guid, BaseDbContext>, IBookIssueRepository
{
    public BookIssueRepository(BaseDbContext context) : base(context)
    {
    }
}