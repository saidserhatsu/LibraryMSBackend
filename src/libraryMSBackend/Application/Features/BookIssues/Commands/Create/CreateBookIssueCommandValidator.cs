using FluentValidation;

namespace Application.Features.BookIssues.Commands.Create;

public class CreateBookIssueCommandValidator : AbstractValidator<CreateBookIssueCommand>
{
    public CreateBookIssueCommandValidator()
    {
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.LibraryStaffId).NotEmpty();
        RuleFor(c => c.ReturnDate).NotEmpty();
    }
}