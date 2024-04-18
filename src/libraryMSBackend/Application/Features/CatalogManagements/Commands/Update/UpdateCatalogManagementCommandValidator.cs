using FluentValidation;

namespace Application.Features.CatalogManagements.Commands.Update;

public class UpdateCatalogManagementCommandValidator : AbstractValidator<UpdateCatalogManagementCommand>
{
    public UpdateCatalogManagementCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.MaterialId).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MagazineId).NotEmpty();
        RuleFor(c => c.CatalogId).NotEmpty();
    }
}