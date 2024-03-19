using FluentValidation;

namespace Application.Features.BookReservations.Commands.Delete;

public class DeleteBookReservationCommandValidator : AbstractValidator<DeleteBookReservationCommand>
{
    public DeleteBookReservationCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}