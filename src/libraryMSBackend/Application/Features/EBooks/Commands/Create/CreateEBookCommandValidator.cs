using FluentValidation;

namespace Application.Features.EBooks.Commands.Create;

public class CreateEBookCommandValidator : AbstractValidator<CreateEBookCommand>
{
    public CreateEBookCommandValidator()
    {
        RuleFor(c => c.FileUrl).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
    }
}