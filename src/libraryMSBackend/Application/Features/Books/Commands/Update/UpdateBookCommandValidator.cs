using FluentValidation;

namespace Application.Features.Books.Commands.Update;

public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
{
    public UpdateBookCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.BookTitle).NotEmpty();
        RuleFor(c => c.BookEdition).NotEmpty();
        RuleFor(b => b.ReleaseDate).NotEmpty()
            .LessThanOrEqualTo(DateTime.Now.Year) // Geçerli yýl veya önceki bir yýl olmalý
            .WithMessage("Yayýn tarihi bu yýl veya önceki bir yýl olmalýdýr.");
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.LocationId).NotEmpty();
    }
}