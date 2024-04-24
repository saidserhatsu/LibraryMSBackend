using Application.Features.FavoriteBooks.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FavoriteBooks;

public class FavoriteBookManager : IFavoriteBookService
{
    private readonly IFavoriteBookRepository _favoriteBookRepository;
    private readonly FavoriteBookBusinessRules _favoriteBookBusinessRules;

    public FavoriteBookManager(IFavoriteBookRepository favoriteBookRepository, FavoriteBookBusinessRules favoriteBookBusinessRules)
    {
        _favoriteBookRepository = favoriteBookRepository;
        _favoriteBookBusinessRules = favoriteBookBusinessRules;
    }

    public async Task<FavoriteBook?> GetAsync(
        Expression<Func<FavoriteBook, bool>> predicate,
        Func<IQueryable<FavoriteBook>, IIncludableQueryable<FavoriteBook, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        FavoriteBook? favoriteBook = await _favoriteBookRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return favoriteBook;
    }

    public async Task<IPaginate<FavoriteBook>?> GetListAsync(
        Expression<Func<FavoriteBook, bool>>? predicate = null,
        Func<IQueryable<FavoriteBook>, IOrderedQueryable<FavoriteBook>>? orderBy = null,
        Func<IQueryable<FavoriteBook>, IIncludableQueryable<FavoriteBook, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<FavoriteBook> favoriteBookList = await _favoriteBookRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return favoriteBookList;
    }

    public async Task<FavoriteBook> AddAsync(FavoriteBook favoriteBook)
    {
        FavoriteBook addedFavoriteBook = await _favoriteBookRepository.AddAsync(favoriteBook);

        return addedFavoriteBook;
    }

    public async Task<FavoriteBook> UpdateAsync(FavoriteBook favoriteBook)
    {
        FavoriteBook updatedFavoriteBook = await _favoriteBookRepository.UpdateAsync(favoriteBook);

        return updatedFavoriteBook;
    }

    public async Task<FavoriteBook> DeleteAsync(FavoriteBook favoriteBook, bool permanent = false)
    {
        FavoriteBook deletedFavoriteBook = await _favoriteBookRepository.DeleteAsync(favoriteBook);

        return deletedFavoriteBook;
    }
}
