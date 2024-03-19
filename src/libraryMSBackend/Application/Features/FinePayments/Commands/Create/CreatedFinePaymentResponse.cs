using NArchitecture.Core.Application.Responses;

namespace Application.Features.FinePayments.Commands.Create;

public class CreatedFinePaymentResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }
}