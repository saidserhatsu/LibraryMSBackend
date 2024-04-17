using Application.Features.MemberSettings.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.MemberSettings;

public class MemberSettingManager : IMemberSettingService
{
    private readonly IMemberSettingRepository _memberSettingRepository;
    private readonly MemberSettingBusinessRules _memberSettingBusinessRules;

    public MemberSettingManager(IMemberSettingRepository memberSettingRepository, MemberSettingBusinessRules memberSettingBusinessRules)
    {
        _memberSettingRepository = memberSettingRepository;
        _memberSettingBusinessRules = memberSettingBusinessRules;
    }

    public async Task<MemberSetting?> GetAsync(
        Expression<Func<MemberSetting, bool>> predicate,
        Func<IQueryable<MemberSetting>, IIncludableQueryable<MemberSetting, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        MemberSetting? memberSetting = await _memberSettingRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return memberSetting;
    }

    public async Task<IPaginate<MemberSetting>?> GetListAsync(
        Expression<Func<MemberSetting, bool>>? predicate = null,
        Func<IQueryable<MemberSetting>, IOrderedQueryable<MemberSetting>>? orderBy = null,
        Func<IQueryable<MemberSetting>, IIncludableQueryable<MemberSetting, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<MemberSetting> memberSettingList = await _memberSettingRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return memberSettingList;
    }

    public async Task<MemberSetting> AddAsync(MemberSetting memberSetting)
    {
        MemberSetting addedMemberSetting = await _memberSettingRepository.AddAsync(memberSetting);

        return addedMemberSetting;
    }

    public async Task<MemberSetting> UpdateAsync(MemberSetting memberSetting)
    {
        MemberSetting updatedMemberSetting = await _memberSettingRepository.UpdateAsync(memberSetting);

        return updatedMemberSetting;
    }

    public async Task<MemberSetting> DeleteAsync(MemberSetting memberSetting, bool permanent = false)
    {
        MemberSetting deletedMemberSetting = await _memberSettingRepository.DeleteAsync(memberSetting);

        return deletedMemberSetting;
    }
}
