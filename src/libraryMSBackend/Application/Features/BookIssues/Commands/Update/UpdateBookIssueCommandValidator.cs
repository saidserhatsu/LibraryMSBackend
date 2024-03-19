using FluentValidation;

namespace Application.Features.BookIssues.Commands.Update;

public class UpdateBookIssueCommandValidator : AbstractValidator<UpdateBookIssueCommand>
{
    public UpdateBookIssueCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.BookId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.LibraryStaffId).NotEmpty();
        RuleFor(c => c.ReturnDate).NotEmpty();
    }
}