using Application.Features.Books.Queries.GetList;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Org.BouncyCastle.Bcpg.Sig;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IBookRepository : IAsyncRepository<Book, Guid>, IRepository<Book, Guid>
{
}