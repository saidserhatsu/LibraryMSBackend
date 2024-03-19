using FluentValidation;

namespace Application.Features.FineDues.Commands.Create;

public class CreateFineDueCommandValidator : AbstractValidator<CreateFineDueCommand>
{
    public CreateFineDueCommandValidator()
    {
        RuleFor(c => c.FineTotal).NotEmpty();
        RuleFor(c => c.RegistrationId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.FineDate).NotEmpty();
    }
}