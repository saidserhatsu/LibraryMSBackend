using FluentValidation;

namespace Application.Features.Magazines.Commands.Update;

public class UpdateMagazineCommandValidator : AbstractValidator<UpdateMagazineCommand>
{
    public UpdateMagazineCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ISSNCode).NotEmpty();
        RuleFor(c => c.MagazineTitle).NotEmpty();
        RuleFor(c => c.ReleaseDate).NotEmpty();
        RuleFor(c => c.Number).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.CatalogId).NotEmpty();
    }
}