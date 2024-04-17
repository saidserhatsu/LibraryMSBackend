using NArchitecture.Core.Application.Responses;

namespace Application.Features.EBooks.Queries.GetById;

public class GetByIdEBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string FileUrl { get; set; }
    public Guid? BookId { get; set; }
}