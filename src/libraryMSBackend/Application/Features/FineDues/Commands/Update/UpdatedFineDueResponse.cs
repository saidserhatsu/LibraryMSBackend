using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Commands.Update;

public class UpdatedFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }
}