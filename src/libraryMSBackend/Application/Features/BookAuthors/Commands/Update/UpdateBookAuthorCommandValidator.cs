using FluentValidation;

namespace Application.Features.BookAuthors.Commands.Update;

public class UpdateBookAuthorCommandValidator : AbstractValidator<UpdateBookAuthorCommand>
{
    public UpdateBookAuthorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.AuthorId).NotEmpty();
    }
}