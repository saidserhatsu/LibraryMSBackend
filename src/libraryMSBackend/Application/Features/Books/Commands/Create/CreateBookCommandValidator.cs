using FluentValidation;

namespace Application.Features.Books.Commands.Create;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.BookTitle).NotEmpty();
        RuleFor(c => c.BookEdition).NotEmpty();
        RuleFor(c => c.ReleaseDate).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.LocationId).NotEmpty();
    }
}