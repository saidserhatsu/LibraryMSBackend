using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.Announcements.Queries.GetList;

public class GetListAnnouncementListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Tag { get; set; }
}