using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FinePayments;

public interface IFinePaymentService
{
    Task<FinePayment?> GetAsync(
        Expression<Func<FinePayment, bool>> predicate,
        Func<IQueryable<FinePayment>, IIncludableQueryable<FinePayment, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<FinePayment>?> GetListAsync(
        Expression<Func<FinePayment, bool>>? predicate = null,
        Func<IQueryable<FinePayment>, IOrderedQueryable<FinePayment>>? orderBy = null,
        Func<IQueryable<FinePayment>, IIncludableQueryable<FinePayment, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<FinePayment> AddAsync(FinePayment finePayment);
    Task<FinePayment> UpdateAsync(FinePayment finePayment);
    Task<FinePayment> DeleteAsync(FinePayment finePayment, bool permanent = false);
}
