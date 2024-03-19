using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Queries.GetById;

public class GetByIdFineDueResponse : IResponse
{
    public Guid Id { get; set; }
    public string FineTotal { get; set; }
    public Guid RegistrationId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime FineDate { get; set; }
}