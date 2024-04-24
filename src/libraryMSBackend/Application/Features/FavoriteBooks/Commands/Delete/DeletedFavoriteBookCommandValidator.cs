using FluentValidation;

namespace Application.Features.FavoriteBooks.Commands.Delete;

public class DeleteFavoriteBookCommandValidator : AbstractValidator<DeleteFavoriteBookCommand>
{
    public DeleteFavoriteBookCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}