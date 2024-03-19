using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IFinePaymentRepository : IAsyncRepository<FinePayment, Guid>, IRepository<FinePayment, Guid>
{
}