using NArchitecture.Core.Application.Responses;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }

    public GetByIdUserResponse()
    {

        MemberId = Guid.Empty;
    }

    public GetByIdUserResponse(Guid id, Guid memberId)
    {
        Id = id;
        MemberId = memberId;
    }
}
