using NArchitecture.Core.Application.Responses;

namespace Application.Features.Members.Commands.Update;

public class UpdatedMemberResponse : IResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }
}