using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System.Data;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class BookRepository : EfRepositoryBase<Book, Guid, BaseDbContext>, IBookRepository
{
    public BookRepository(BaseDbContext context) : base(context)
    {
    }
}