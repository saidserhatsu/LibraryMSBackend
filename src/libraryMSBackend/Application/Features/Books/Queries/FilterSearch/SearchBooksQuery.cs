using MediatR;
using System;
using System.Linq;
using System.Threading;

using Application.Services.Repositories;
using AutoMapper;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using Application.Features.Books.Queries.GetList;
using Microsoft.EntityFrameworkCore;

public class SearchBooksQuery : IRequest<GetListResponse<GetListBookListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchBooksQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}

public class SearchBooksQueryHandler : IRequestHandler<SearchBooksQuery, GetListResponse<GetListBookListItemDto>>
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public SearchBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListBookListItemDto>> Handle(SearchBooksQuery request, CancellationToken cancellationToken)
    {
        // Başlangıç noktası
        var query = _bookRepository.Table;

        // Kitap başlığına göre filtreleme
        if (!string.IsNullOrEmpty(request.Criteria.BookTitle))
        {
            query = query.Where(b => b.BookTitle.Contains(request.Criteria.BookTitle));
        }

        // ISBN koduna göre filtreleme
        if (!string.IsNullOrEmpty(request.Criteria.BookISBNCode))
        {
            query = query.Where(b => b.ISBNCode.Contains(request.Criteria.BookISBNCode));
        }

        // Yazar adını içeren kitapları filtreleme
        if (!string.IsNullOrEmpty(request.Criteria.AuthorName))
        {
            query = query.Where(b => b.BookAuthors.Any(ba => ba.Author.FirstName.Contains(request.Criteria.AuthorName)));
        }
        // Magazine title için arama 
        if (!string.IsNullOrEmpty(request.Criteria.MagazineTitle))
        {
            query = query.Where(b => b.Category.Magazines.Any(ba => ba.MagazineTitle.Contains(request.Criteria.MagazineTitle)));
        }
        // Magazine ıssn code için arama 
        if (!string.IsNullOrEmpty(request.Criteria.MagazineISSNCode))
        {
            query = query.Where(b => b.Category.Magazines.Any(ba => ba.ISSNCode.Contains(request.Criteria.MagazineISSNCode)));
        }
        // materialtype
        //if (!string.IsNullOrEmpty(request.Criteria.MaterialType))
        //{
        //    query = query.Where(b => b.Category.Materials.Any(ba => ba.MaterialType.(request.Criteria.MaterialType)));
        //}

        // İlişkili varlıkları dahil etme
        query = query.Include(b => b.BookAuthors)
                     .ThenInclude(ba => ba.Author)
                     .Include(ba=>ba.Category).ThenInclude(ba=>ba.Materials)
                     .Include(ba=>ba.Category).ThenInclude(ba=>ba.Magazines)
                     ;

        // Yazar soyadını içeren kitapları filtreleme
        if (!string.IsNullOrEmpty(request.Criteria.AuthorSurname))
        {
            query = query.Where(b => b.BookAuthors.Any(ba=>ba.Author.LastName.Contains(request.Criteria.AuthorSurname)));
        }

        // Sorguyu sayfalama
        IPaginate<Book> paginatedQuery = await query.ToPaginateAsync(
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Mapleme ve yanıt oluşturma
        GetListResponse<GetListBookListItemDto> response = _mapper.Map<GetListResponse<GetListBookListItemDto>>(paginatedQuery);
        return response;
    }

}