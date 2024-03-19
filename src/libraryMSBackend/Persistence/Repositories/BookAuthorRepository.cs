using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookAuthorRepository : EfRepositoryBase<BookAuthor, Guid, BaseDbContext>, IBookAuthorRepository
{
    public BookAuthorRepository(BaseDbContext context) : base(context)
    {
    }
}