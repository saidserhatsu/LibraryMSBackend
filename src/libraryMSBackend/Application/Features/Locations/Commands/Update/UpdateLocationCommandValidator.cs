using FluentValidation;

namespace Application.Features.Locations.Commands.Update;

public class UpdateLocationCommandValidator : AbstractValidator<UpdateLocationCommand>
{
    public UpdateLocationCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ShelfNo).NotEmpty();
        RuleFor(c => c.FloorNo).NotEmpty();
        RuleFor(c => c.ShelfName).NotEmpty();
        RuleFor(c => c.LibraryName).NotEmpty();
    }
}