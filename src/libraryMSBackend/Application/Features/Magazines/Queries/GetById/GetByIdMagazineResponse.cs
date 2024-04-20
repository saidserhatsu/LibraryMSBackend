using NArchitecture.Core.Application.Responses;

namespace Application.Features.Magazines.Queries.GetById;

public class GetByIdMagazineResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISSNCode { get; set; }
    public string MagazineTitle { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Number { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
}