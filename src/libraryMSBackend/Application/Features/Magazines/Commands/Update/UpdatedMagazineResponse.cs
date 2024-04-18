using NArchitecture.Core.Application.Responses;

namespace Application.Features.Magazines.Commands.Update;

public class UpdatedMagazineResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISSNCode { get; set; }
    public string MagazineTitle { get; set; }
    public int ReleaseDate { get; set; }
    public int Number { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
}