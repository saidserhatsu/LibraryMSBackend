using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Queries.GetById;

public class GetByIdFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }
    public string MemberEmail { get; set; }
}