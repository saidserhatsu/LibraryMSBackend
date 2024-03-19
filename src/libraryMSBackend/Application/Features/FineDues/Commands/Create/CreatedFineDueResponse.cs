using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Commands.Create;

public class CreatedFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }
}