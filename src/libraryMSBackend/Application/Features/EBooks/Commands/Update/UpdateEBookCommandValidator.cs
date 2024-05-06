using FluentValidation;

namespace Application.Features.EBooks.Commands.Update;

public class UpdateEBookCommandValidator : AbstractValidator<UpdateEBookCommand>
{
    public UpdateEBookCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.EBookTitle).NotEmpty();
        RuleFor(c => c.AuthorName).NotEmpty();
        RuleFor(c => c.ReleaseDate).NotEmpty();
        RuleFor(c => c.PageCount).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}