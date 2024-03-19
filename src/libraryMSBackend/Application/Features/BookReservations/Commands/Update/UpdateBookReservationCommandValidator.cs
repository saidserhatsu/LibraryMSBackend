using FluentValidation;

namespace Application.Features.BookReservations.Commands.Update;

public class UpdateBookReservationCommandValidator : AbstractValidator<UpdateBookReservationCommand>
{
    public UpdateBookReservationCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.NearestAvailableDate).NotEmpty();
        RuleFor(c => c.RequestDate).NotEmpty();
    }
}