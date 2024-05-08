using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FeedBacks.Queries.GetList;

public class GetListFeedBackListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}