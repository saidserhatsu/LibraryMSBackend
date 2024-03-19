using Application.Features.FinePayments.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FinePayments;

public class FinePaymentManager : IFinePaymentService
{
    private readonly IFinePaymentRepository _finePaymentRepository;
    private readonly FinePaymentBusinessRules _finePaymentBusinessRules;

    public FinePaymentManager(IFinePaymentRepository finePaymentRepository, FinePaymentBusinessRules finePaymentBusinessRules)
    {
        _finePaymentRepository = finePaymentRepository;
        _finePaymentBusinessRules = finePaymentBusinessRules;
    }

    public async Task<FinePayment?> GetAsync(
        Expression<Func<FinePayment, bool>> predicate,
        Func<IQueryable<FinePayment>, IIncludableQueryable<FinePayment, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        FinePayment? finePayment = await _finePaymentRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return finePayment;
    }

    public async Task<IPaginate<FinePayment>?> GetListAsync(
        Expression<Func<FinePayment, bool>>? predicate = null,
        Func<IQueryable<FinePayment>, IOrderedQueryable<FinePayment>>? orderBy = null,
        Func<IQueryable<FinePayment>, IIncludableQueryable<FinePayment, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<FinePayment> finePaymentList = await _finePaymentRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return finePaymentList;
    }

    public async Task<FinePayment> AddAsync(FinePayment finePayment)
    {
        FinePayment addedFinePayment = await _finePaymentRepository.AddAsync(finePayment);

        return addedFinePayment;
    }

    public async Task<FinePayment> UpdateAsync(FinePayment finePayment)
    {
        FinePayment updatedFinePayment = await _finePaymentRepository.UpdateAsync(finePayment);

        return updatedFinePayment;
    }

    public async Task<FinePayment> DeleteAsync(FinePayment finePayment, bool permanent = false)
    {
        FinePayment deletedFinePayment = await _finePaymentRepository.DeleteAsync(finePayment);

        return deletedFinePayment;
    }
}
