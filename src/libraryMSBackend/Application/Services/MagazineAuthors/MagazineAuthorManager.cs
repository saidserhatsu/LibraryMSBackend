using Application.Features.MagazineAuthors.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.MagazineAuthors;

public class MagazineAuthorManager : IMagazineAuthorService
{
    private readonly IMagazineAuthorRepository _magazineAuthorRepository;
    private readonly MagazineAuthorBusinessRules _magazineAuthorBusinessRules;

    public MagazineAuthorManager(IMagazineAuthorRepository magazineAuthorRepository, MagazineAuthorBusinessRules magazineAuthorBusinessRules)
    {
        _magazineAuthorRepository = magazineAuthorRepository;
        _magazineAuthorBusinessRules = magazineAuthorBusinessRules;
    }

    public async Task<MagazineAuthor?> GetAsync(
        Expression<Func<MagazineAuthor, bool>> predicate,
        Func<IQueryable<MagazineAuthor>, IIncludableQueryable<MagazineAuthor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        MagazineAuthor? magazineAuthor = await _magazineAuthorRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return magazineAuthor;
    }

    public async Task<IPaginate<MagazineAuthor>?> GetListAsync(
        Expression<Func<MagazineAuthor, bool>>? predicate = null,
        Func<IQueryable<MagazineAuthor>, IOrderedQueryable<MagazineAuthor>>? orderBy = null,
        Func<IQueryable<MagazineAuthor>, IIncludableQueryable<MagazineAuthor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<MagazineAuthor> magazineAuthorList = await _magazineAuthorRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return magazineAuthorList;
    }

    public async Task<MagazineAuthor> AddAsync(MagazineAuthor magazineAuthor)
    {
        MagazineAuthor addedMagazineAuthor = await _magazineAuthorRepository.AddAsync(magazineAuthor);

        return addedMagazineAuthor;
    }

    public async Task<MagazineAuthor> UpdateAsync(MagazineAuthor magazineAuthor)
    {
        MagazineAuthor updatedMagazineAuthor = await _magazineAuthorRepository.UpdateAsync(magazineAuthor);

        return updatedMagazineAuthor;
    }

    public async Task<MagazineAuthor> DeleteAsync(MagazineAuthor magazineAuthor, bool permanent = false)
    {
        MagazineAuthor deletedMagazineAuthor = await _magazineAuthorRepository.DeleteAsync(magazineAuthor);

        return deletedMagazineAuthor;
    }
}
