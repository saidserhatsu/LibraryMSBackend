using NArchitecture.Core.Application.Dtos;

namespace Application.Features.SearchCriterias.Queries.GetList;

public class GetListSearchCriteriaListItemDto : IDto
{
    public Guid Id { get; set; }
    public string? BookTitle { get; set; }
    public string? MagazineTitle { get; set; }
    public string? MaterialName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? MagazineISSNCode { get; set; }
    public string? BookISBNCode { get; set; }
}