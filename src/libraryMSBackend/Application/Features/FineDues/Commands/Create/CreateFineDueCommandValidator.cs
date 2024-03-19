using FluentValidation;

namespace Application.Features.FineDues.Commands.Create;

public class CreateFineDueCommandValidator : AbstractValidator<CreateFineDueCommand>
{
    public CreateFineDueCommandValidator()
    {
        RuleFor(c => c.FineTotal).NotEmpty();
        RuleFor(c => c.BookIssueId).NotEmpty();
        RuleFor(c => c.FineDate).NotEmpty();
    }
}