using Application.Features.Books.Queries.GetList;
using Application.Features.Categories.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.MemberSettings.Queries.GetList;
using Application.Features.Publishers.Queries.GetList;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Members.Queries.GetById;

public class GetByIdMemberResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }

    public GetListMemberSettingListItemDto MemberSetting { get; set; }
    public List<GetListBookListItemDto> Books { get; set; }

}