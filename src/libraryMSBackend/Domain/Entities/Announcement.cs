using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Announcement : Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; } = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714736430/ouaussgfi9enxrecymah.jpg";
    public AnnouncementTag Tag { get; set; }
}
