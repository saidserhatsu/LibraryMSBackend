using FluentValidation;

namespace Application.Features.MemberSettings.Commands.Delete;

public class DeleteMemberSettingCommandValidator : AbstractValidator<DeleteMemberSettingCommand>
{
    public DeleteMemberSettingCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}