using NArchitecture.Core.Application.Dtos;

namespace Application.Features.MemberSettings.Queries.GetList;

public class GetListMemberSettingListItemDto : IDto
{
    public int Id { get; set; }
    public string UiTheme { get; set; }
    public string Language { get; set; }
}