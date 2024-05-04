using Application.Features.BookIssues.Queries.Statistics;
using Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.BookIssues.Queries.Statistics
{
    public class BookIssueMonthlyStatisticsQuery : IRequest<List<BookIssueMonthlyStatisticsDto>>
    {
    }
}
public class BookIssueMonthlyStatisticsDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int BookIssueCount { get; set; }
}
public class BookIssueMonthlyStatisticsQueryHandler : IRequestHandler<BookIssueMonthlyStatisticsQuery, List<BookIssueMonthlyStatisticsDto>>
{
    private readonly IBookIssueRepository _bookIssueRepository;

    public BookIssueMonthlyStatisticsQueryHandler(IBookIssueRepository bookIssueRepository)
    {
        _bookIssueRepository = bookIssueRepository;
    }

    public async Task<List<BookIssueMonthlyStatisticsDto>> Handle(BookIssueMonthlyStatisticsQuery request, CancellationToken cancellationToken)
    {
        var monthlyStatistics = await _bookIssueRepository.Table
            .IgnoreQueryFilters() // Soft delete'i dikkate almaz
            .GroupBy(bi => new { bi.CreatedDate.Year, bi.CreatedDate.Month })
            .Select(g => new BookIssueMonthlyStatisticsDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                BookIssueCount = g.Count() // Silinmiş olanlar dahil say
            })
            .OrderBy(ms => ms.Year)
            .ThenBy(ms => ms.Month)
            .ToListAsync(cancellationToken);

        return monthlyStatistics;
    }
}


