using Application.Services.Repositories;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class BookStatisticsQuery : IRequest<int>
{
    public BookStatus Status { get; set; }

    public BookStatisticsQuery(BookStatus status)
    {
        Status = status;
    }
}

public class BookStatisticsQueryHandler : IRequestHandler<BookStatisticsQuery, int>
{
    private readonly IBookRepository _bookRepository;

    public BookStatisticsQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<int> Handle(BookStatisticsQuery request, CancellationToken cancellationToken)
    {
        return await _bookRepository.Table.Where(b => b.Status == request.Status).CountAsync(cancellationToken);
    }
}
