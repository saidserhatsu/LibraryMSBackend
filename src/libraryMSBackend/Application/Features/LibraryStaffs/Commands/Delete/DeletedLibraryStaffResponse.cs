using NArchitecture.Core.Application.Responses;

namespace Application.Features.LibraryStaffs.Commands.Delete;

public class DeletedLibraryStaffResponse : IResponse
{
    public Guid Id { get; set; }
}