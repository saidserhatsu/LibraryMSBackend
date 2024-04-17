using FluentValidation;

namespace Application.Features.Magazines.Commands.Create;

public class CreateMagazineCommandValidator : AbstractValidator<CreateMagazineCommand>
{
    public CreateMagazineCommandValidator()
    {
        RuleFor(c => c.ISSNCode).NotEmpty();
        RuleFor(c => c.MagazineTitle).NotEmpty();
        RuleFor(c => c.ReleaseDate).NotEmpty();
        RuleFor(c => c.Number).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.CatalogId).NotEmpty();
    }
}