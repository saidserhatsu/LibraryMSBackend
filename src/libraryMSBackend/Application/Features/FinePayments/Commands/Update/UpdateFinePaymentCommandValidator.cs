using FluentValidation;

namespace Application.Features.FinePayments.Commands.Update;

public class UpdateFinePaymentCommandValidator : AbstractValidator<UpdateFinePaymentCommand>
{
    public UpdateFinePaymentCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.PaymentAmount).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
    }
}