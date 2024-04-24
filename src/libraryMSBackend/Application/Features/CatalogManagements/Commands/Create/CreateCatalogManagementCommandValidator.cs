using FluentValidation;

namespace Application.Features.CatalogManagements.Commands.Create;

public class CreateCatalogManagementCommandValidator : AbstractValidator<CreateCatalogManagementCommand>
{
    public CreateCatalogManagementCommandValidator()
    {
        RuleFor(c => c.CatalogId).NotEmpty();
    }
}