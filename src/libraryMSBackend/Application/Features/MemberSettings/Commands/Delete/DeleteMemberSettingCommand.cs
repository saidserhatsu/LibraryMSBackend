using Application.Features.MemberSettings.Constants;
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

namespace Application.Features.MemberSettings.Commands.Delete;

public class DeleteMemberSettingCommand : IRequest<DeletedMemberSettingResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int Id { get; set; }

    public string[] Roles => [Admin, Write, MemberSettingsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMemberSettings"];

    public class DeleteMemberSettingCommandHandler : IRequestHandler<DeleteMemberSettingCommand, DeletedMemberSettingResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberSettingRepository _memberSettingRepository;
        private readonly MemberSettingBusinessRules _memberSettingBusinessRules;

        public DeleteMemberSettingCommandHandler(IMapper mapper, IMemberSettingRepository memberSettingRepository,
                                         MemberSettingBusinessRules memberSettingBusinessRules)
        {
            _mapper = mapper;
            _memberSettingRepository = memberSettingRepository;
            _memberSettingBusinessRules = memberSettingBusinessRules;
        }

        public async Task<DeletedMemberSettingResponse> Handle(DeleteMemberSettingCommand request, CancellationToken cancellationToken)
        {
            MemberSetting? memberSetting = await _memberSettingRepository.GetAsync(predicate: ms => ms.Id == request.Id, cancellationToken: cancellationToken);
            await _memberSettingBusinessRules.MemberSettingShouldExistWhenSelected(memberSetting);

            await _memberSettingRepository.DeleteAsync(memberSetting!);

            DeletedMemberSettingResponse response = _mapper.Map<DeletedMemberSettingResponse>(memberSetting);
            return response;
        }
    }
}