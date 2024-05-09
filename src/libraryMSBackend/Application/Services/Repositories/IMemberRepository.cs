using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IMemberRepository : IAsyncRepository<Member, Guid>, IRepository<Member, Guid>
{
    IQueryable<Member> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
    Task<Member> GetByMemberIdAsync(Guid memberId);
    Task<int> CountAsync();

}