using NArchitecture.Core.Application.Responses;

namespace Application.Features.MemberSettings.Queries.GetById;

public class GetByIdMemberSettingResponse : IResponse
{
    public int Id { get; set; }
    public string UiTheme { get; set; }
    public string Language { get; set; }
}