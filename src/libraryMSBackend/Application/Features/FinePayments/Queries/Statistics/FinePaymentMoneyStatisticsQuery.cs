using Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FinePayments.Queries.Statistics;
public class FinePaymentMoneyStatisticsQuery:IRequest<Decimal>
{
}

public class FinePaymentMoneyStatisticsQueryHandler : IRequestHandler<FinePaymentMoneyStatisticsQuery, decimal>
{
    private readonly IFinePaymentRepository  _finePaymentRepository;
    public FinePaymentMoneyStatisticsQueryHandler(IFinePaymentRepository finePaymentRepository)
    {
        _finePaymentRepository = finePaymentRepository;
    }
    public async Task<decimal> Handle(FinePaymentMoneyStatisticsQuery request, CancellationToken cancellationToken)
    {
        decimal totalFine = await _finePaymentRepository.Table.SumAsync(fp => fp.PaymentAmount, cancellationToken);//PaymentAmount toplamını al

        return totalFine;// Toplam para tutarını döndür
    }
}
