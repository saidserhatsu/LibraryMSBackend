using Application.Features.BookAuthors.Commands.Create;
using Application.Features.BookAuthors.Commands.Delete;
using Application.Features.BookAuthors.Commands.Update;
using Application.Features.BookAuthors.Queries.GetById;
using Application.Features.BookAuthors.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.BookAuthors.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<BookAuthor, CreateBookAuthorCommand>().ReverseMap();
        CreateMap<BookAuthor, CreatedBookAuthorResponse>().ReverseMap();
        CreateMap<BookAuthor, UpdateBookAuthorCommand>().ReverseMap();
        CreateMap<BookAuthor, UpdatedBookAuthorResponse>().ReverseMap();
        CreateMap<BookAuthor, DeleteBookAuthorCommand>().ReverseMap();
        CreateMap<BookAuthor, DeletedBookAuthorResponse>().ReverseMap();
        CreateMap<BookAuthor, GetByIdBookAuthorResponse>().ReverseMap();
        CreateMap<BookAuthor, GetListBookAuthorListItemDto>().ReverseMap();
        CreateMap<IPaginate<BookAuthor>, GetListResponse<GetListBookAuthorListItemDto>>().ReverseMap();
    }
}