using FluentValidation;

namespace Application.Features.FineDues.Commands.Delete;

public class DeleteFineDueCommandValidator : AbstractValidator<DeleteFineDueCommand>
{
    public DeleteFineDueCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}