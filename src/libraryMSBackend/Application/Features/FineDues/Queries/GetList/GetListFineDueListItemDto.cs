using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FineDues.Queries.GetList;

public class GetListFineDueListItemDto : IDto
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }
}