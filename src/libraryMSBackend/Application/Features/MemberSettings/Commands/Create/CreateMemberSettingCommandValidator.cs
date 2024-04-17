using FluentValidation;

namespace Application.Features.MemberSettings.Commands.Create;

public class CreateMemberSettingCommandValidator : AbstractValidator<CreateMemberSettingCommand>
{
    public CreateMemberSettingCommandValidator()
    {
        RuleFor(c => c.UiTheme).NotEmpty();
        RuleFor(c => c.Language).NotEmpty();
    }
}