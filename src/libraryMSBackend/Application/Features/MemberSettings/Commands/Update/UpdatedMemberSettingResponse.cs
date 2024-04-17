using NArchitecture.Core.Application.Responses;

namespace Application.Features.MemberSettings.Commands.Update;

public class UpdatedMemberSettingResponse : IResponse
{
    public int Id { get; set; }
    public string UiTheme { get; set; }
    public string Language { get; set; }
}