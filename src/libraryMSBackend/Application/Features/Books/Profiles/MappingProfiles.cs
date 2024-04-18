using Application.Features.Authors.Queries.GetById;
using Application.Features.Authors.Queries.GetList;
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
        CreateMap<Book, GetByIdBookResponse>().ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors
                .Select(ba => new GetListAuthorListItemDto
                {
                    Id = ba.Author.Id,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                }))).ReverseMap();
        CreateMap<Book, GetListBookListItemDto>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors
                .Select(ba => new GetListAuthorListItemDto
                {
                    Id = ba.Author.Id,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                })));
        CreateMap<IPaginate<Book>, GetListResponse<GetListBookListItemDto>>().ReverseMap();
    }
}