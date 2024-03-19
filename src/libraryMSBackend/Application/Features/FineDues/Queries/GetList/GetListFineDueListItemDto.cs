using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FineDues.Queries.GetList;

public class GetListFineDueListItemDto : IDto
{
    public Guid Id { get; set; }
    public string FineTotal { get; set; }
    public Guid RegistrationId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime FineDate { get; set; }
}