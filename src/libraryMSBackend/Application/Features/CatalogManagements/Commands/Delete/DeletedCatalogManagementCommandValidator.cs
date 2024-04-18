using FluentValidation;

namespace Application.Features.CatalogManagements.Commands.Delete;

public class DeleteCatalogManagementCommandValidator : AbstractValidator<DeleteCatalogManagementCommand>
{
    public DeleteCatalogManagementCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}