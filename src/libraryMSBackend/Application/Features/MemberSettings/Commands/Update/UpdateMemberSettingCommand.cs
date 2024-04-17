using Application.Features.MemberSettings.Constants;
using Application.Features.MemberSettings.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.MemberSettings.Constants.MemberSettingsOperationClaims;

namespace Application.Features.MemberSettings.Commands.Update;

public class UpdateMemberSettingCommand : IRequest<UpdatedMemberSettingResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int Id { get; set; }
    public string UiTheme { get; set; }
    public string Language { get; set; }

    public string[] Roles => [Admin, Write, MemberSettingsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMemberSettings"];

    public class UpdateMemberSettingCommandHandler : IRequestHandler<UpdateMemberSettingCommand, UpdatedMemberSettingResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberSettingRepository _memberSettingRepository;
        private readonly MemberSettingBusinessRules _memberSettingBusinessRules;

        public UpdateMemberSettingCommandHandler(IMapper mapper, IMemberSettingRepository memberSettingRepository,
                                         MemberSettingBusinessRules memberSettingBusinessRules)
        {
            _mapper = mapper;
            _memberSettingRepository = memberSettingRepository;
            _memberSettingBusinessRules = memberSettingBusinessRules;
        }

        public async Task<UpdatedMemberSettingResponse> Handle(UpdateMemberSettingCommand request, CancellationToken cancellationToken)
        {
            MemberSetting? memberSetting = await _memberSettingRepository.GetAsync(predicate: ms => ms.Id == request.Id, cancellationToken: cancellationToken);
            await _memberSettingBusinessRules.MemberSettingShouldExistWhenSelected(memberSetting);
            memberSetting = _mapper.Map(request, memberSetting);

            await _memberSettingRepository.UpdateAsync(memberSetting!);

            UpdatedMemberSettingResponse response = _mapper.Map<UpdatedMemberSettingResponse>(memberSetting);
            return response;
        }
    }
}