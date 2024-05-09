using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LibraryStaffRepository : EfRepositoryBase<LibraryStaff, Guid, BaseDbContext>, ILibraryStaffRepository
{
    public LibraryStaffRepository(BaseDbContext context) : base(context)
    {
    }
    public async Task<int> CountAsync()
    {
        // Kitap sayýsýný saymak için gerekli kod
        return await Context.LibraryStaffs.CountAsync();
    }
}