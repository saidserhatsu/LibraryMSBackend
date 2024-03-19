using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Commands.Create;

public class CreatedFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public string FineTotal { get; set; }
    public Guid RegistrationId { get; set; }
    public DateTime FineDate { get; set; }
}