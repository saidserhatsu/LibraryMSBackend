using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.LibraryStaffs;

public interface ILibraryStaffService
{
    Task<LibraryStaff?> GetAsync(
        Expression<Func<LibraryStaff, bool>> predicate,
        Func<IQueryable<LibraryStaff>, IIncludableQueryable<LibraryStaff, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<LibraryStaff>?> GetListAsync(
        Expression<Func<LibraryStaff, bool>>? predicate = null,
        Func<IQueryable<LibraryStaff>, IOrderedQueryable<LibraryStaff>>? orderBy = null,
        Func<IQueryable<LibraryStaff>, IIncludableQueryable<LibraryStaff, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<LibraryStaff> AddAsync(LibraryStaff libraryStaff);
    Task<LibraryStaff> UpdateAsync(LibraryStaff libraryStaff);
    Task<LibraryStaff> DeleteAsync(LibraryStaff libraryStaff, bool permanent = false);
}
