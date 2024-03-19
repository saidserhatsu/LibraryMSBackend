using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FinePaymentRepository : EfRepositoryBase<FinePayment, Guid, BaseDbContext>, IFinePaymentRepository
{
    public FinePaymentRepository(BaseDbContext context) : base(context)
    {
    }
}