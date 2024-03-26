using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Announcement : Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public AnnouncementTag Tag { get; set; }
}
