using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookRepository : EfRepositoryBase<Book, Guid, BaseDbContext>, IBookRepository
{
    public BookRepository(BaseDbContext context) : base(context)
    {
    }

    private DbSet<Book> Books => Context.Set<Book>(); // DbSet eriþimi

    public IQueryable<Book> Table => Books.AsQueryable(); // IQueryable eriþimi

    public async Task<Book> GetByIdAsync(Guid bookId)
    {
        var book = await Books.FirstOrDefaultAsync(b => b.Id == bookId);

        if (book == null)
        {
            throw new KeyNotFoundException($"No book found with ID {bookId}");
        }

        return book;
    }
}