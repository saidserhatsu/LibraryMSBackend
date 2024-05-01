using Application.Features.Members.Constants;
using FluentValidation;
using NArchitecture.Core.Localization.Abstraction;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    private ILocalizationService _localizationService;

    public CreateMemberCommandValidator(ILocalizationService localizationService)
    {
        _localizationService = localizationService;
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(m => m.PhoneNumber).NotEmpty();
        RuleFor(m => m.PhoneNumber)
            .Matches(@"^\+[0-9]*$") // Telefon numarasi basinda + isareti bulundurmalidir.
            .WithMessage(GetLocalized("ThePhoneNumberMustBeInAValidFormat").Result);
        RuleFor(m => m.DateOfBirth).NotEmpty();
        RuleFor(m => m.DateOfBirth)
            .LessThan(DateTime.Today.AddYears(-7)) // En az 7 yýl önce doðmuþ olmalý.
            .WithMessage(GetLocalized("TheBirthdateMustBeAtLeast7YearsAgo").Result);
    }
    public async Task<string> GetLocalized(string key)
    {
        return await _localizationService.GetLocalizedAsync(key, MembersBusinessMessages.SectionName);
    }
}