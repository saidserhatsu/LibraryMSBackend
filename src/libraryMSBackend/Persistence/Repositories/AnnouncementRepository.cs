using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class AnnouncementRepository : EfRepositoryBase<Announcement, Guid, BaseDbContext>, IAnnouncementRepository
{
    public AnnouncementRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<Announcement> Announcements => Context.Set<Announcement>(); // DbSet eriþimi

    public IQueryable<Announcement> Table => Announcements.AsQueryable(); // IQueryable eriþimi

}