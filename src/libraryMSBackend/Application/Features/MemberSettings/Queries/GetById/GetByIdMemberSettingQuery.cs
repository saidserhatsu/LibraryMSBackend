using Application.Features.MemberSettings.Constants;
using Application.Features.MemberSettings.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.MemberSettings.Constants.MemberSettingsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.MemberSettings.Queries.GetById;

public class GetByIdMemberSettingQuery : IRequest<GetByIdMemberSettingResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdMemberSettingQueryHandler : IRequestHandler<GetByIdMemberSettingQuery, GetByIdMemberSettingResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberSettingRepository _memberSettingRepository;
        private readonly MemberSettingBusinessRules _memberSettingBusinessRules;

        public GetByIdMemberSettingQueryHandler(IMapper mapper, IMemberSettingRepository memberSettingRepository, MemberSettingBusinessRules memberSettingBusinessRules)
        {
            _mapper = mapper;
            _memberSettingRepository = memberSettingRepository;
            _memberSettingBusinessRules = memberSettingBusinessRules;
        }

        public async Task<GetByIdMemberSettingResponse> Handle(GetByIdMemberSettingQuery request, CancellationToken cancellationToken)
        {
            MemberSetting? memberSetting = await _memberSettingRepository.GetAsync(
                predicate: ms => ms.Id == request.Id, cancellationToken: cancellationToken
                );
            await _memberSettingBusinessRules.MemberSettingShouldExistWhenSelected(memberSetting);

            GetByIdMemberSettingResponse response = _mapper.Map<GetByIdMemberSettingResponse>(memberSetting);
            return response;
        }
    }
}