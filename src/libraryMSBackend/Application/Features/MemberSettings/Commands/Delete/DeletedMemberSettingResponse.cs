using NArchitecture.Core.Application.Responses;

namespace Application.Features.MemberSettings.Commands.Delete;

public class DeletedMemberSettingResponse : IResponse
{
    public int Id { get; set; }
}