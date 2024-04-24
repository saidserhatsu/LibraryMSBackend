using FluentValidation;

namespace Application.Features.FavoriteBooks.Commands.Update;

public class UpdateFavoriteBookCommandValidator : AbstractValidator<UpdateFavoriteBookCommand>
{
    public UpdateFavoriteBookCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
    }
}