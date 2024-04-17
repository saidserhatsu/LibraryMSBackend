using FluentValidation;

namespace Application.Features.MemberSettings.Commands.Update;

public class UpdateMemberSettingCommandValidator : AbstractValidator<UpdateMemberSettingCommand>
{
    public UpdateMemberSettingCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.UiTheme).NotEmpty();
        RuleFor(c => c.Language).NotEmpty();
    }
}