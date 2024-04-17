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

namespace Application.Features.MemberSettings.Commands.Create;

public class CreateMemberSettingCommand : IRequest<CreatedMemberSettingResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string UiTheme { get; set; }
    public string Language { get; set; }

    public string[] Roles => [Admin, Write, MemberSettingsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMemberSettings"];

    public class CreateMemberSettingCommandHandler : IRequestHandler<CreateMemberSettingCommand, CreatedMemberSettingResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberSettingRepository _memberSettingRepository;
        private readonly MemberSettingBusinessRules _memberSettingBusinessRules;

        public CreateMemberSettingCommandHandler(IMapper mapper, IMemberSettingRepository memberSettingRepository,
                                         MemberSettingBusinessRules memberSettingBusinessRules)
        {
            _mapper = mapper;
            _memberSettingRepository = memberSettingRepository;
            _memberSettingBusinessRules = memberSettingBusinessRules;
        }

        public async Task<CreatedMemberSettingResponse> Handle(CreateMemberSettingCommand request, CancellationToken cancellationToken)
        {
            MemberSetting memberSetting = _mapper.Map<MemberSetting>(request);

            await _memberSettingRepository.AddAsync(memberSetting);

            CreatedMemberSettingResponse response = _mapper.Map<CreatedMemberSettingResponse>(memberSetting);
            return response;
        }
    }
}