using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class MemberSettingRepository : EfRepositoryBase<MemberSetting, int, BaseDbContext>, IMemberSettingRepository
{
    public MemberSettingRepository(BaseDbContext context) : base(context)
    {
    }
}