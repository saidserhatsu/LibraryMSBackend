using Application.Features.Auth.Constants;
using FluentValidation;
using NArchitecture.Core.Localization.Abstraction;

namespace Application.Features.Books.Commands.Create;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    private ILocalizationService _localizationService;
    public CreateBookCommandValidator()
    {
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.BookTitle).NotEmpty();
        RuleFor(c => c.BookEdition).NotEmpty();
        RuleFor(b => b.ReleaseDate).NotEmpty()
            .LessThanOrEqualTo(DateTime.Now.Year) // Ge�erli y�l veya �nceki bir y�l olmal�
            .WithMessage("Yay�n tarihi bu y�l veya �nceki bir y�l olmal�d�r.");
        RuleFor(b => b.PageCount).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.LocationId).NotEmpty();
    }

    public async Task<string> GetLocalized(string key)
    {
        return await _localizationService.GetLocalizedAsync(key,AuthMessages.SectionName);
    }
}