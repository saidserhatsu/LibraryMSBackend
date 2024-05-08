using FluentValidation;

namespace Application.Features.FeedBacks.Commands.Create;

public class CreateFeedBackCommandValidator : AbstractValidator<CreateFeedBackCommand>
{
    public CreateFeedBackCommandValidator()
    {
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.PhoneNumber).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}