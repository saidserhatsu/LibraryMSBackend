using FluentValidation;

namespace Application.Features.Locations.Commands.Update;

public class UpdateLocationCommandValidator : AbstractValidator<UpdateLocationCommand>
{
    public UpdateLocationCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.ShelfNo).NotEmpty();
        RuleFor(c => c.FloorNo).NotEmpty();
        RuleFor(c => c.ShelfName).NotEmpty();
    }
}