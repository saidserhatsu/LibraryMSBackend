using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookReservationRepository : EfRepositoryBase<BookReservation, Guid, BaseDbContext>, IBookReservationRepository
{
    public BookReservationRepository(BaseDbContext context) : base(context)
    {
    }

    public IQueryable<BookReservation> Table => Context.Set<BookReservation>();
}