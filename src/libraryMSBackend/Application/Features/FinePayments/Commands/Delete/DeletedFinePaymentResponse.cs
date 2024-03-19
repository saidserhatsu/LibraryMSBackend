using NArchitecture.Core.Application.Responses;

namespace Application.Features.FinePayments.Commands.Delete;

public class DeletedFinePaymentResponse : IResponse
{
    public Guid Id { get; set; }
}