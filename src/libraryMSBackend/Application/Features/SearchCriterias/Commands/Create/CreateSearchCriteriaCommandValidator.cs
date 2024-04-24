using FluentValidation;

namespace Application.Features.SearchCriterias.Commands.Create;

public class CreateSearchCriteriaCommandValidator : AbstractValidator<CreateSearchCriteriaCommand>
{
    public CreateSearchCriteriaCommandValidator()
    {
        RuleFor(c => c.BookTitle).NotEmpty();
        RuleFor(c => c.MagazineTitle).NotEmpty();
        RuleFor(c => c.MaterialName).NotEmpty();
        RuleFor(c => c.AuthorName).NotEmpty();
        RuleFor(c => c.AuthorSurname).NotEmpty();
        RuleFor(c => c.MagazineISSNCode).NotEmpty();
        RuleFor(c => c.BookISBNCode).NotEmpty();
    }
}