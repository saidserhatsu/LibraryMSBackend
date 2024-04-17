using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.MemberSettings;

public interface IMemberSettingService
{
    Task<MemberSetting?> GetAsync(
        Expression<Func<MemberSetting, bool>> predicate,
        Func<IQueryable<MemberSetting>, IIncludableQueryable<MemberSetting, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<MemberSetting>?> GetListAsync(
        Expression<Func<MemberSetting, bool>>? predicate = null,
        Func<IQueryable<MemberSetting>, IOrderedQueryable<MemberSetting>>? orderBy = null,
        Func<IQueryable<MemberSetting>, IIncludableQueryable<MemberSetting, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<MemberSetting> AddAsync(MemberSetting memberSetting);
    Task<MemberSetting> UpdateAsync(MemberSetting memberSetting);
    Task<MemberSetting> DeleteAsync(MemberSetting memberSetting, bool permanent = false);
}
