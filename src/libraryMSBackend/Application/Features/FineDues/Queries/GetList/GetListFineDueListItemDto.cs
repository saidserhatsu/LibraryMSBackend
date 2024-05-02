using Application.Features.Books.Queries.GetList;
using Application.Features.Members.Queries.GetList;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FineDues.Queries.GetList;

public class GetListFineDueListItemDto : IDto
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }

    public string BookIssueMemberFirstName { get; set;}
    public string BookIssueMemberLastName { get; set;}
    public string BookIssueBookBookTitle { get; set;}
    public string BookIssueReturnDate { get; set;}
    
}