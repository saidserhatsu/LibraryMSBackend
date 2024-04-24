using NArchitecture.Core.Application.Dtos;

namespace Application.Features.BookReservations.Queries.GetList;

public class GetListBookReservationListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookBookTitle { get; set; }
    public string BookStatus { get; set; }
    public Guid MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public DateTime NearestAvailableDate { get; set; }
    public DateTime RequestDate { get; set; }

}