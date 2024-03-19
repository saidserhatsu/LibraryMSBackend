using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookIssues.Commands.Delete;

public class DeletedBookIssueResponse : IResponse
{
    public Guid Id { get; set; }
}