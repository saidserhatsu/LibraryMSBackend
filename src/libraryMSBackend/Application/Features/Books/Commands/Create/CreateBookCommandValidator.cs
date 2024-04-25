using Application.Features.Auth.Constants;
using Application.Features.Books.Constants;
using FluentValidation;
using NArchitecture.Core.Localization.Abstraction;

namespace Application.Features.Books.Commands.Create;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    private ILocalizationService _localizationService;
    public CreateBookCommandValidator(ILocalizationService localizationService)
    {
        _localizationService=localizationService;
        RuleFor(c => c.ISBNCode).NotEmpty();
        RuleFor(c => c.BookTitle).NotEmpty();
        RuleFor(c => c.BookEdition).NotEmpty();
        RuleFor(b => b.ReleaseDate).NotEmpty();
        RuleFor(b => b.ReleaseDate).LessThanOrEqualTo(DateTime.Now.Year)// Geçerli yýl veya önceki bir yýl olmalý
                                   .WithMessage(GetLocalized("ThePublicationDateMustBeThisYearOrThePreviousYear").Result);
        RuleFor(b => b.PageCount).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.PublisherId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.LocationId).NotEmpty();
    }

    public async Task<string> GetLocalized(string key)
    {
        return await _localizationService.GetLocalizedAsync(key, BooksBusinessMessages.SectionName);
    }
}