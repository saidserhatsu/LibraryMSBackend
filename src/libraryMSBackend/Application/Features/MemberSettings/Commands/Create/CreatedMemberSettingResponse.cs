using NArchitecture.Core.Application.Responses;

namespace Application.Features.MemberSettings.Commands.Create;

public class CreatedMemberSettingResponse : IResponse
{
    public int Id { get; set; }
    public string UiTheme { get; set; }
    public string Language { get; set; }
}