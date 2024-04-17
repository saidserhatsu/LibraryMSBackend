using NArchitecture.Core.Application.Dtos;

namespace Application.Features.EBooks.Queries.GetList;

public class GetListEBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public string FileUrl { get; set; }
    public Guid? BookId { get; set; }
}