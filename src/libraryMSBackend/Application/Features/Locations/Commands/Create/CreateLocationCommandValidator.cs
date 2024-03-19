using FluentValidation;

namespace Application.Features.Locations.Commands.Create;

public class CreateLocationCommandValidator : AbstractValidator<CreateLocationCommand>
{
    public CreateLocationCommandValidator()
    {
        RuleFor(c => c.ShelfNo).NotEmpty();
        RuleFor(c => c.FloorNo).NotEmpty();
        RuleFor(c => c.ShelfName).NotEmpty();
        RuleFor(c => c.LibraryName).NotEmpty();
    }
}