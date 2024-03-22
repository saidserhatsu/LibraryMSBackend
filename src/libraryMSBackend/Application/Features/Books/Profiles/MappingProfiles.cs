using Application.Features.Authors.Queries.GetById;
using Application.Features.Books.Commands.Create;
using Application.Features.Books.Commands.Delete;
using Application.Features.Books.Commands.Update;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetById;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Books.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Book, CreateBookCommand>().ReverseMap();
        CreateMap<Book, CreatedBookResponse>().ReverseMap();
        CreateMap<Book, UpdateBookCommand>().ReverseMap();
        CreateMap<Book, UpdatedBookResponse>().ReverseMap();
        CreateMap<Book, DeleteBookCommand>().ReverseMap();
        CreateMap<Book, DeletedBookResponse>().ReverseMap();
        CreateMap<Book, GetByIdBookResponse>().ReverseMap();
        //CreateMap<GetListBookListItemDto, Book>().ForMember(dest => dest.Location, act => act.MapFrom(src => src.LocationName));
        //CreateMap<Book, GetListBookListItemDto>().
        //    ForMember(dest => dest.AuthorsDto, act => act.MapFrom(src => src.BookAuthors.FirstOrDefault().Author.FirstName)).ReverseMap();
        CreateMap<Book, GetListBookListItemDto>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.AuthorsDto, opt => opt.MapFrom(src => src.BookAuthors.Select(a => new GetByIdAuthorResponse
                {
                    Id = a.Author.Id,
                    FirstName = a.Author.FirstName,
                    LastName = a.Author.LastName
                })));

        CreateMap<Author, GetByIdAuthorResponse>().ReverseMap();
        CreateMap<Location, GetByIdLocationResponse>().ReverseMap();

        CreateMap<IPaginate<Book>, GetListResponse<GetListBookListItemDto>>().ReverseMap();
    }
}