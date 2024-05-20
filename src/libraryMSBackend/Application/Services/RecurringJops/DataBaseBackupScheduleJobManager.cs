using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NArchitecture.Core.Localization.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.RecurringJops;
public class DataBaseBackupScheduleJobManager
{
    private readonly IFineDueRepository _fineDueRepository;
    private readonly IBookIssueRepository _bookIssueRepository;

    public DataBaseBackupScheduleJobManager(IFineDueRepository fineDueRepository, IBookIssueRepository bookIssueRepository)
    {
        _fineDueRepository = fineDueRepository;
        _bookIssueRepository = bookIssueRepository;
    }
    public async Task Process()
    {
        var bookIssues = _bookIssueRepository.Table;

        foreach (var bookIssue in bookIssues)
        {
            var returnDate = bookIssue.ReturnDate;
            var daysDifference = (DateTime.Now - returnDate).TotalDays;

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
            }
        }
    }
}
