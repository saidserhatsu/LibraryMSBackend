using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LibraryStaffRepository : EfRepositoryBase<LibraryStaff, Guid, BaseDbContext>, ILibraryStaffRepository
{
    public LibraryStaffRepository(BaseDbContext context) : base(context)
    {
    }
}