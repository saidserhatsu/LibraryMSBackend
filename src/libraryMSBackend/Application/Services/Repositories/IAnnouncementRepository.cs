using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IAnnouncementRepository : IAsyncRepository<Announcement, Guid>, IRepository<Announcement, Guid>
{
    IQueryable<Announcement> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
}