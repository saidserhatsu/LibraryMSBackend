using FluentValidation;

namespace Application.Features.FinePayments.Commands.Delete;

public class DeleteFinePaymentCommandValidator : AbstractValidator<DeleteFinePaymentCommand>
{
    public DeleteFinePaymentCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}