using FluentValidation;

namespace Application.Features.BookAuthors.Commands.Create;

public class CreateBookAuthorCommandValidator : AbstractValidator<CreateBookAuthorCommand>
{
    public CreateBookAuthorCommandValidator()
    {
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.AuthorId).NotEmpty();
    }
}