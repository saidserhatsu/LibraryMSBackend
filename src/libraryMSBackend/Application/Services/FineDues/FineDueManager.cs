using Application.Features.FineDues.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FineDues;

public class FineDueManager : IFineDueService
{
    private readonly IFineDueRepository _fineDueRepository;
    private readonly IBookIssueRepository _bookIssueRepository;

    public FineDueManager(IFineDueRepository fineDueRepository, IBookIssueRepository bookIssueRepository)
    {
        _fineDueRepository = fineDueRepository;
        _bookIssueRepository = bookIssueRepository;
    }

    public async Task<FineDue?> GetAsync(
        Expression<Func<FineDue, bool>> predicate,
        Func<IQueryable<FineDue>, IIncludableQueryable<FineDue, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        FineDue? fineDue = await _fineDueRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return fineDue;
    }

    public async Task<IPaginate<FineDue>?> GetListAsync(
        Expression<Func<FineDue, bool>>? predicate = null,
        Func<IQueryable<FineDue>, IOrderedQueryable<FineDue>>? orderBy = null,
        Func<IQueryable<FineDue>, IIncludableQueryable<FineDue, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<FineDue> fineDueList = await _fineDueRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return fineDueList;
    }

    public async Task<FineDue> AddAsync(FineDue fineDue)
    {
        FineDue addedFineDue = await _fineDueRepository.AddAsync(fineDue);

        return addedFineDue;
    }

    public async Task<FineDue> UpdateAsync(FineDue fineDue)
    {
        FineDue updatedFineDue = await _fineDueRepository.UpdateAsync(fineDue);

        return updatedFineDue;
    }

    public async Task<FineDue> DeleteAsync(FineDue fineDue, bool permanent = false)
    {
        FineDue deletedFineDue = await _fineDueRepository.DeleteAsync(fineDue);

        return deletedFineDue;
    }
    public async Task Process()
    {
        var overdueBookIssues = await _bookIssueRepository.GetOverdueBookIssuesAsync();

        var processedBookIssueIds = new HashSet<Guid>(); // Ýþlenen kitap iade ID'lerini saklamak için bir HashSet oluþturuldu.

        foreach (var bookIssue in overdueBookIssues)
        {
            if (processedBookIssueIds.Contains(bookIssue.Id)) // Eðer kitap iadesi daha önce iþlendi ise atla.
            {
                continue;
            }

            var daysDifference = (DateTime.Now - bookIssue.ReturnDate).TotalDays;

            if (daysDifference > 0)
            {
                double penaltyAmount = daysDifference * 3; // Örnek ceza hesaplama
                var bookIssueId = bookIssue.Id;

                var existingFineDue = await _fineDueRepository.GetAsync(fd => fd.BookIssueId == bookIssueId);

                if (existingFineDue != null)
                {
                    existingFineDue.FineDate = DateTime.Now;
                    existingFineDue.FineTotal = (decimal)penaltyAmount;
                    await _fineDueRepository.UpdateAsync(existingFineDue); // Güncelleme
                }
                else
                {
                    FineDue newFineDue = new FineDue()
                    {
                        BookIssueId = bookIssueId,
                        FineTotal = (decimal)penaltyAmount,
                        FineDate = DateTime.Now
                    };

                    await _fineDueRepository.AddAsync(newFineDue); // Yeni ekleme
                }

                processedBookIssueIds.Add(bookIssue.Id); // Kitap iadesini iþlendi olarak iþaretle.
            }
        }
    }
}