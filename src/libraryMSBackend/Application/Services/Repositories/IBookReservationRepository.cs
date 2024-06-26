using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IBookReservationRepository : IAsyncRepository<BookReservation, Guid>, IRepository<BookReservation, Guid>
{
    IQueryable<BookReservation> Table { get; }
}