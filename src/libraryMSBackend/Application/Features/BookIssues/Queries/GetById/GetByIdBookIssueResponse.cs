using Application.Features.FineDues.Queries.GetList;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookIssues.Queries.GetById;

public class GetByIdBookIssueResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookBookTitle { get; set; }
    public string BookStatus { get; set; }
    public Guid MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public Guid LibraryStaffId { get; set; }
    public string LibraryStaffFirstName { get; set; }
    public string LibraryStaffLastName { get; set; }
    public DateTime ReturnDate { get; set; }
    public Guid FineDueId { get; set; }

    public List<GetListFineDueListItemDto> FineDues { get; set; }
}