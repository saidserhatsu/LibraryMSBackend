using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookIssues.Queries.GetById;

public class GetByIdBookIssueResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }
    public DateTime ReturnDate { get; set; }
}