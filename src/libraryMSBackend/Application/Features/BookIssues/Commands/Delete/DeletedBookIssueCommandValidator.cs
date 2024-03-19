using FluentValidation;

namespace Application.Features.BookIssues.Commands.Delete;

public class DeleteBookIssueCommandValidator : AbstractValidator<DeleteBookIssueCommand>
{
    public DeleteBookIssueCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}