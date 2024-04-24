using FluentValidation;

namespace Application.Features.FavoriteBooks.Commands.Create;

public class CreateFavoriteBookCommandValidator : AbstractValidator<CreateFavoriteBookCommand>
{
    public CreateFavoriteBookCommandValidator()
    {
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
    }
}