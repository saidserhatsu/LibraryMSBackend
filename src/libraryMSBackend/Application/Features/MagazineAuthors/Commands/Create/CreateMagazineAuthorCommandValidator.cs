using FluentValidation;

namespace Application.Features.MagazineAuthors.Commands.Create;

public class CreateMagazineAuthorCommandValidator : AbstractValidator<CreateMagazineAuthorCommand>
{
    public CreateMagazineAuthorCommandValidator()
    {
        RuleFor(c => c.MagazineId).NotEmpty();
        RuleFor(c => c.AuthorId).NotEmpty();
    }
}