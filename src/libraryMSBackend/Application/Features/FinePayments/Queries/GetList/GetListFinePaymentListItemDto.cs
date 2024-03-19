using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FinePayments.Queries.GetList;

public class GetListFinePaymentListItemDto : IDto
{
    public Guid Id { get; set; }
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }
}