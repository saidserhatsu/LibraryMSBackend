using Application.Features.MemberSettings.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.MemberSettings.Constants.MemberSettingsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.MemberSettings.Queries.GetList;

public class GetListMemberSettingQuery : IRequest<GetListResponse<GetListMemberSettingListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListMemberSettings({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetMemberSettings";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListMemberSettingQueryHandler : IRequestHandler<GetListMemberSettingQuery, GetListResponse<GetListMemberSettingListItemDto>>
    {
        private readonly IMemberSettingRepository _memberSettingRepository;
        private readonly IMapper _mapper;

        public GetListMemberSettingQueryHandler(IMemberSettingRepository memberSettingRepository, IMapper mapper)
        {
            _memberSettingRepository = memberSettingRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMemberSettingListItemDto>> Handle(GetListMemberSettingQuery request, CancellationToken cancellationToken)
        {
            IPaginate<MemberSetting> memberSettings = await _memberSettingRepository.GetListAsync(
             
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListMemberSettingListItemDto> response = _mapper.Map<GetListResponse<GetListMemberSettingListItemDto>>(memberSettings);
            return response;
        }
    }
}