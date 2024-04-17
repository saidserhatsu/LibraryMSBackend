using FluentValidation;

namespace Application.Features.MagazineAuthors.Commands.Delete;

public class DeleteMagazineAuthorCommandValidator : AbstractValidator<DeleteMagazineAuthorCommand>
{
    public DeleteMagazineAuthorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}