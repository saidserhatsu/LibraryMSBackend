using Application.Features.Authors.Queries.GetById;
using Application.Features.Authors.Queries.GetList;
using Application.Features.Books.Commands.Create;
using Application.Features.Books.Commands.Delete;
using Application.Features.Books.Commands.Update;
using Application.Features.Books.Queries.FilterSearch;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetById;
using Application.Features.Magazines.Queries.GetList;
using Application.Features.Materials.Queries.GetList;
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
                .ForMember(dest => dest.Locations, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors
                .Select(ba => new GetListAuthorListItemDto
                {
                    Id = ba.Author.Id,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                })));

        //CreateMap<Book, SearchBooksResponse>()
        //        .ForMember(dest => dest.ISBNCode, opt => opt.MapFrom(src => src.ISBNCode))
        //        .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.BookTitle))
        //        .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors
        //           .Select(ba => new GetListAuthorListItemDto
        //           {
        //                FirstName = ba.Author.FirstName,
        //                LastName = ba.Author.LastName,
        //                Id = ba.Author.Id
        //           })));

        CreateMap<Book, SearchBooksResponse>()
      .ForMember(dest => dest.ISBNCode, opt => opt.MapFrom(src => src.ISBNCode))
      .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.BookTitle))
      .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors
          .Select(ba => new GetListAuthorListItemDto
          {
              FirstName = ba.Author.FirstName,
              LastName = ba.Author.LastName,
              Id = ba.Author.Id
          })))
      .ForMember(dest => dest.Magazines, opt => opt.MapFrom(src => src.Category.Magazines
      .Select(ba => new GetListMagazineListItemDto
      {
          MagazineTitle = ba.MagazineTitle,
          ISSNCode = ba.ISSNCode,
          Number = ba.Number,
          ReleaseDate = ba.ReleaseDate

      })))
      .ForMember(dest => dest.Materials, opt => opt.MapFrom(src => src.Category.Materials
      .Select(ba => new GetListMaterialListItemDto
      {
          MaterialType = ba.MaterialType,
          Name = ba.Name,
          ReleaseDate = ba.ReleaseDate,
      }
      )));







        CreateMap<IPaginate<Book>, GetListResponse<GetListBookListItemDto>>().ReverseMap();
    }
}