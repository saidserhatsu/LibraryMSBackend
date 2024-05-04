using Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FineDues.Queries.Statistics;
public class FineDueMoneyStatisticsQuery:IRequest<Decimal>
{
    
}

public class FineDueMoneyStatisticsQueryHandler : IRequestHandler<FineDueMoneyStatisticsQuery, decimal>
{
    private readonly IFineDueRepository _fineDueRepository;

    public FineDueMoneyStatisticsQueryHandler(IFineDueRepository fineDueRepository)
    {
        _fineDueRepository = fineDueRepository;
    }

    public async Task<decimal> Handle(FineDueMoneyStatisticsQuery request, CancellationToken cancellationToken)
    {
        // FineDue tablosunda toplam para tutarını hesapla
        decimal totalFine = await _fineDueRepository.Table
            .SumAsync(fd => fd.FineTotal, cancellationToken); // FineTotal alanının toplamını al

        return totalFine; // Toplam para tutarını döndür
    }
}
