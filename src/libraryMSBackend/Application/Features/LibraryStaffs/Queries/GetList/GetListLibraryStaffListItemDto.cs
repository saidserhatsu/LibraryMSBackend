using NArchitecture.Core.Application.Dtos;

namespace Application.Features.LibraryStaffs.Queries.GetList;

public class GetListLibraryStaffListItemDto : IDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
}