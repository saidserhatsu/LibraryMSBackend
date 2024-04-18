using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Users.Queries.GetList;

public class GetListUserListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }

    public GetListUserListItemDto()
    {
        MemberId = Guid.Empty;
        Email = string.Empty;
    }

    public GetListUserListItemDto(Guid id, Guid memberId, string email)
    {
        Id = id;
        MemberId = memberId;
        Email = email;
    }
}
