using FluentValidation;

namespace Application.Features.MagazineAuthors.Commands.Update;

public class UpdateMagazineAuthorCommandValidator : AbstractValidator<UpdateMagazineAuthorCommand>
{
    public UpdateMagazineAuthorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.MagazineId).NotEmpty();
        RuleFor(c => c.AuthorId).NotEmpty();
    }
}