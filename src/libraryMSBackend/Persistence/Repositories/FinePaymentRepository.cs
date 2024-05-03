using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FinePaymentRepository : EfRepositoryBase<FinePayment, Guid, BaseDbContext>, IFinePaymentRepository
{
    public FinePaymentRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<FinePayment> FinePayments => Context.Set<FinePayment>(); // DbSet eriþimi

    public IQueryable<FinePayment> Table => FinePayments.AsQueryable(); // IQueryable eriþimi
}