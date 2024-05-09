using Application.Features.Books.Queries.GetList;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Nest;
using Org.BouncyCastle.Bcpg.Sig;
using System.Linq;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IBookRepository : IAsyncRepository<Book, Guid>, IRepository<Book, Guid>
{

    IQueryable<Book> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.

    Task<int> CountAsync();
    Task<Book> GetByIdAsync(Guid bookId);


}