using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookReservations.Commands.Update;

public class UpdatedBookReservationResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public bool AvaibleStatus { get; set; }
    public DateTime NearestAvailableDate { get; set; }
    public DateTime RequestDate { get; set; }
}