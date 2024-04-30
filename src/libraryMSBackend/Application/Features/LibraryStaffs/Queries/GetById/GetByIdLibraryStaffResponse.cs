using NArchitecture.Core.Application.Responses;

namespace Application.Features.LibraryStaffs.Queries.GetById;

public class GetByIdLibraryStaffResponse : IResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
}