using NArchitecture.Core.Application.Responses;

namespace Application.Features.FinePayments.Commands.Update;

public class UpdatedFinePaymentResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }
}