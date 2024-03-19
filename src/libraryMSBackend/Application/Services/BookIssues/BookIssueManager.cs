using Application.Features.BookIssues.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BookIssues;

public class BookIssueManager : IBookIssueService
{
    private readonly IBookIssueRepository _bookIssueRepository;
    private readonly BookIssueBusinessRules _bookIssueBusinessRules;

    public BookIssueManager(IBookIssueRepository bookIssueRepository, BookIssueBusinessRules bookIssueBusinessRules)
    {
        _bookIssueRepository = bookIssueRepository;
        _bookIssueBusinessRules = bookIssueBusinessRules;
    }

    public async Task<BookIssue?> GetAsync(
        Expression<Func<BookIssue, bool>> predicate,
        Func<IQueryable<BookIssue>, IIncludableQueryable<BookIssue, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return bookIssue;
    }

    public async Task<IPaginate<BookIssue>?> GetListAsync(
        Expression<Func<BookIssue, bool>>? predicate = null,
        Func<IQueryable<BookIssue>, IOrderedQueryable<BookIssue>>? orderBy = null,
        Func<IQueryable<BookIssue>, IIncludableQueryable<BookIssue, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<BookIssue> bookIssueList = await _bookIssueRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return bookIssueList;
    }

    public async Task<BookIssue> AddAsync(BookIssue bookIssue)
    {
        BookIssue addedBookIssue = await _bookIssueRepository.AddAsync(bookIssue);

        return addedBookIssue;
    }

    public async Task<BookIssue> UpdateAsync(BookIssue bookIssue)
    {
        BookIssue updatedBookIssue = await _bookIssueRepository.UpdateAsync(bookIssue);

        return updatedBookIssue;
    }

    public async Task<BookIssue> DeleteAsync(BookIssue bookIssue, bool permanent = false)
    {
        BookIssue deletedBookIssue = await _bookIssueRepository.DeleteAsync(bookIssue);

        return deletedBookIssue;
    }
}
