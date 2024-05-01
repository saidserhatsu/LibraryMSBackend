using Application.Features.Members.Constants;
using FluentValidation;
using NArchitecture.Core.Localization.Abstraction;

namespace Application.Features.Members.Commands.Update;

public class UpdateMemberCommandValidator : AbstractValidator<UpdateMemberCommand>
{
    private ILocalizationService _localizationService;
    public UpdateMemberCommandValidator(ILocalizationService localizationService)
    {
        _localizationService = localizationService;
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(m => m.PhoneNumber)
             .Matches(@"^\+[0-9]*$") // Telefon numarasi basinda + isareti bulundurmalidir.
             .WithMessage(GetLocalized("ThePhoneNumberMustBeInAValidFormat").Result);
        RuleFor(m => m.DateOfBirth).NotEmpty()
            .LessThan(DateTime.Today.AddYears(-7)) // En az 7 yýl önce doðmuþ olmalý.
            .WithMessage("Doðum tarihi en az 7 yýl önce olmalýdýr.");
        RuleFor(c => c.Subscribe).NotEmpty();
    }

    public async Task<string> GetLocalized(string key)
    {
        return await _localizationService.GetLocalizedAsync(key, MembersBusinessMessages.SectionName);
    }
}