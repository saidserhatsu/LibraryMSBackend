using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookReservations.Commands.Delete;

public class DeletedBookReservationResponse : IResponse
{
    public Guid Id { get; set; }
}