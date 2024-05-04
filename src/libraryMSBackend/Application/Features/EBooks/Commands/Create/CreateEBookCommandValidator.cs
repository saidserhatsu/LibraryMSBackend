using FluentValidation;

namespace Application.Features.EBooks.Commands.Create;

public class CreateEBookCommandValidator : AbstractValidator<CreateEBookCommand>
{
    public CreateEBookCommandValidator()
    {
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.EBookTitle).NotEmpty();
        RuleFor(c => c.AuthorName).NotEmpty();
        RuleFor(c => c.ReleaseDate).NotEmpty();
        RuleFor(c => c.PageCount).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}