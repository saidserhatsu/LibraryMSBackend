using NArchitecture.Core.Application.Dtos;

namespace Application.Features.BookIssues.Queries.GetList;

public class GetListBookIssueListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }
    public DateTime ReturnDate { get; set; }
}