using NArchitecture.Core.Application.Responses;

namespace Application.Features.SearchCriterias.Commands.Create;

public class CreatedSearchCriteriaResponse : IResponse
{
    public Guid Id { get; set; }
    public string BookTitle { get; set; }
    public string MagazineTitle { get; set; }
    public string MaterialType { get; set; }
    public string AuthorName { get; set; }
    public string AuthorSurname { get; set; }
    public string MagazineISSNCode { get; set; }
    public string BookISBNCode { get; set; }
}