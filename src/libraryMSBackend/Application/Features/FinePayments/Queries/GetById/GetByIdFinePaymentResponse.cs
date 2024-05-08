using NArchitecture.Core.Application.Responses;

namespace Application.Features.FinePayments.Queries.GetById;

public class GetByIdFinePaymentResponse : IResponse
{
    public Guid Id { get; set; }
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public string MemberEmail { get; set; }
}