using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Materials.Queries.GetById;

public class GetByIdMaterialResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string MaterialType { get; set; }
    public int ReleaseDate { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
    public string PublisherName { get; set; }
    public string CategoryName { get; set; }
}