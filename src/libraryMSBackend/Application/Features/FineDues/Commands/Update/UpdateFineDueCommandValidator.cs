using FluentValidation;

namespace Application.Features.FineDues.Commands.Update;

public class UpdateFineDueCommandValidator : AbstractValidator<UpdateFineDueCommand>
{
    public UpdateFineDueCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FineTotal).NotEmpty();
        RuleFor(c => c.BookIssueId).NotEmpty();
        RuleFor(c => c.FineDate).NotEmpty();
    }
}