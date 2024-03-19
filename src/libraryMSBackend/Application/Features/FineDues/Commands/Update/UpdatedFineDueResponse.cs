using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Commands.Update;

public class UpdatedFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public string FineTotal { get; set; }
    public Guid RegistrationId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime FineDate { get; set; }
}