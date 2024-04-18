namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserResponse : NArchitecture.Core.Application.Responses.IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public string Email { get; set; }

    public GetByIdUserResponse()
    {

        MemberId = Guid.Empty;
        Email = string.Empty;
    }

    public GetByIdUserResponse(Guid id, Guid memberId, string email)
    {
        Id = id;
        MemberId = memberId;
        Email = email;
    }
}
