using FluentValidation;

namespace Application.Features.FeedBacks.Commands.Update;

public class UpdateFeedBackCommandValidator : AbstractValidator<UpdateFeedBackCommand>
{
    public UpdateFeedBackCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.PhoneNumber).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}