using FluentValidation;

namespace Application.Features.Catalogs.Commands.Delete;

public class DeleteCatalogCommandValidator : AbstractValidator<DeleteCatalogCommand>
{
    public DeleteCatalogCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}