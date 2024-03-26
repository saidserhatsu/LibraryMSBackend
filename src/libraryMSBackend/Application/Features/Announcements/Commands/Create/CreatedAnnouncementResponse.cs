using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Announcements.Commands.Create;

public class CreatedAnnouncementResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public AnnouncementTag Tag { get; set; }
}