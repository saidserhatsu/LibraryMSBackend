using FluentValidation;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.PhoneNumber).NotEmpty();
        RuleFor(c => c.DateOfBirth).NotEmpty();
        RuleFor(c => c.Subscribe).NotEmpty();
    }
}