using FluentValidation;

namespace Application.Features.Catalogs.Commands.Create;

public class CreateCatalogCommandValidator : AbstractValidator<CreateCatalogCommand>
{
    public CreateCatalogCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
    }
}