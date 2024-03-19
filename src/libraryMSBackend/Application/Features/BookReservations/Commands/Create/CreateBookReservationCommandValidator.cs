using FluentValidation;

namespace Application.Features.BookReservations.Commands.Create;

public class CreateBookReservationCommandValidator : AbstractValidator<CreateBookReservationCommand>
{
    public CreateBookReservationCommandValidator()
    {
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.AvaibleStatus).NotEmpty();
        RuleFor(c => c.NearestAvailableDate).NotEmpty();
        RuleFor(c => c.RequestDate).NotEmpty();
    }
}