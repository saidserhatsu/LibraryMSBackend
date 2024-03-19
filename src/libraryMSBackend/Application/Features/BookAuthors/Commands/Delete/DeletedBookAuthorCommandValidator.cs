using FluentValidation;

namespace Application.Features.BookAuthors.Commands.Delete;

public class DeleteBookAuthorCommandValidator : AbstractValidator<DeleteBookAuthorCommand>
{
    public DeleteBookAuthorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}