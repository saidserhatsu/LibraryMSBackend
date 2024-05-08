using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FeedBackRepository : EfRepositoryBase<FeedBack, Guid, BaseDbContext>, IFeedBackRepository
{
    public FeedBackRepository(BaseDbContext context) : base(context)
    {
    }
}