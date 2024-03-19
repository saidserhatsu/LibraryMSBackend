using Application.Features.LibraryStaffs.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.LibraryStaffs;

public class LibraryStaffManager : ILibraryStaffService
{
    private readonly ILibraryStaffRepository _libraryStaffRepository;
    private readonly LibraryStaffBusinessRules _libraryStaffBusinessRules;

    public LibraryStaffManager(ILibraryStaffRepository libraryStaffRepository, LibraryStaffBusinessRules libraryStaffBusinessRules)
    {
        _libraryStaffRepository = libraryStaffRepository;
        _libraryStaffBusinessRules = libraryStaffBusinessRules;
    }

    public async Task<LibraryStaff?> GetAsync(
        Expression<Func<LibraryStaff, bool>> predicate,
        Func<IQueryable<LibraryStaff>, IIncludableQueryable<LibraryStaff, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        LibraryStaff? libraryStaff = await _libraryStaffRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return libraryStaff;
    }

    public async Task<IPaginate<LibraryStaff>?> GetListAsync(
        Expression<Func<LibraryStaff, bool>>? predicate = null,
        Func<IQueryable<LibraryStaff>, IOrderedQueryable<LibraryStaff>>? orderBy = null,
        Func<IQueryable<LibraryStaff>, IIncludableQueryable<LibraryStaff, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<LibraryStaff> libraryStaffList = await _libraryStaffRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return libraryStaffList;
    }

    public async Task<LibraryStaff> AddAsync(LibraryStaff libraryStaff)
    {
        LibraryStaff addedLibraryStaff = await _libraryStaffRepository.AddAsync(libraryStaff);

        return addedLibraryStaff;
    }

    public async Task<LibraryStaff> UpdateAsync(LibraryStaff libraryStaff)
    {
        LibraryStaff updatedLibraryStaff = await _libraryStaffRepository.UpdateAsync(libraryStaff);

        return updatedLibraryStaff;
    }

    public async Task<LibraryStaff> DeleteAsync(LibraryStaff libraryStaff, bool permanent = false)
    {
        LibraryStaff deletedLibraryStaff = await _libraryStaffRepository.DeleteAsync(libraryStaff);

        return deletedLibraryStaff;
    }
}
