using Application.Features.BookAuthors.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookAuthors;

public class BookAuthorManager : IBookAuthorService
{
    private readonly IBookAuthorRepository _bookAuthorRepository;
    private readonly BookAuthorBusinessRules _bookAuthorBusinessRules;

    public BookAuthorManager(IBookAuthorRepository bookAuthorRepository, BookAuthorBusinessRules bookAuthorBusinessRules)
    {
        _bookAuthorRepository = bookAuthorRepository;
        _bookAuthorBusinessRules = bookAuthorBusinessRules;
    }

    public async Task<BookAuthor?> GetAsync(
        Expression<Func<BookAuthor, bool>> predicate,
        Func<IQueryable<BookAuthor>, IIncludableQueryable<BookAuthor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        BookAuthor? bookAuthor = await _bookAuthorRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return bookAuthor;
    }

    public async Task<IPaginate<BookAuthor>?> GetListAsync(
        Expression<Func<BookAuthor, bool>>? predicate = null,
        Func<IQueryable<BookAuthor>, IOrderedQueryable<BookAuthor>>? orderBy = null,
        Func<IQueryable<BookAuthor>, IIncludableQueryable<BookAuthor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<BookAuthor> bookAuthorList = await _bookAuthorRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return bookAuthorList;
    }

    public async Task<BookAuthor> AddAsync(BookAuthor bookAuthor)
    {
        BookAuthor addedBookAuthor = await _bookAuthorRepository.AddAsync(bookAuthor);

        return addedBookAuthor;
    }

    public async Task<BookAuthor> UpdateAsync(BookAuthor bookAuthor)
    {
        BookAuthor updatedBookAuthor = await _bookAuthorRepository.UpdateAsync(bookAuthor);

        return updatedBookAuthor;
    }

    public async Task<BookAuthor> DeleteAsync(BookAuthor bookAuthor, bool permanent = false)
    {
        BookAuthor deletedBookAuthor = await _bookAuthorRepository.DeleteAsync(bookAuthor);

        return deletedBookAuthor;
    }
}
