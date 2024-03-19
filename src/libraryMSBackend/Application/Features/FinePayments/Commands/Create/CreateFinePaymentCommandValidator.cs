using FluentValidation;

namespace Application.Features.FinePayments.Commands.Create;

public class CreateFinePaymentCommandValidator : AbstractValidator<CreateFinePaymentCommand>
{
    public CreateFinePaymentCommandValidator()
    {
        RuleFor(c => c.PaymentAmount).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
    }
}