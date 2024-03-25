using Application.Features.Members.Commands.Create;
using Application.Features.Members.Commands.Delete;
using Application.Features.Members.Commands.Update;
using Application.Features.Members.Queries.GetById;
using Application.Features.Members.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Authors.Queries.GetById;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetById;
using Application.Features.Books.Queries.GetById;
using Application.Features.Publishers.Queries.GetById;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Publishers.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.Categories.Queries.GetList;

namespace Application.Features.Members.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Member, CreateMemberCommand>().ReverseMap();
        CreateMap<Member, CreatedMemberResponse>().ReverseMap();
        CreateMap<Member, UpdateMemberCommand>().ReverseMap();
        CreateMap<Member, UpdatedMemberResponse>().ReverseMap();
        CreateMap<Member, DeleteMemberCommand>().ReverseMap();
        CreateMap<Member, DeletedMemberResponse>().ReverseMap();
        CreateMap<Member, GetByIdMemberResponse>().ReverseMap();
        CreateMap<Member, GetListMemberListItemDto>().ReverseMap();

        CreateMap<Member, GetListMemberListItemDto>()
              .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListBookListItemDto
              {
                  Id = a.BookId,
                  ISBNCode = a.Book.ISBNCode,
                  BookTitle = a.Book.BookTitle,
                  BookEdition = a.Book.BookEdition,
                  ReleaseDate = a.Book.ReleaseDate,
                  Status = a.Book.Status
              })))
              .ForMember(dest => dest.Publishers, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListPublisherListItemDto
              {
                  Id = a.Book.Publisher.Id,
                  Name = a.Book.Publisher.Name,
                  Language = a.Book.Publisher.Language

              })))
              .ForMember(dest => dest.Locations, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListLocationListItemDto
              {
                  Id = a.Book.LocationId,
                  Name = a.Book.Location.Name,
                  FloorNo = a.Book.Location.FloorNo,
                  ShelfNo = a.Book.Location.ShelfNo,
                  ShelfName = a.Book.Location.ShelfName

              })))
              .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListCategoryListItemDto
              {
                  Id = a.Book.Category.Id,
                  Name = a.Book.Category.Name

              })));

        CreateMap<Member, GetByIdMemberResponse>()
             .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListBookListItemDto
             {
                 Id = a.BookId,
                 ISBNCode = a.Book.ISBNCode,
                 BookTitle = a.Book.BookTitle,
                 BookEdition = a.Book.BookEdition,
                 ReleaseDate = a.Book.ReleaseDate,
                 Status = a.Book.Status
             })))
             .ForMember(dest => dest.Publishers, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListPublisherListItemDto
             {
                 Id = a.Book.Publisher.Id,
                 Name = a.Book.Publisher.Name,
                 Language = a.Book.Publisher.Language

             })))
             .ForMember(dest => dest.Locations, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListLocationListItemDto
             {
                 Id = a.Book.LocationId,
                 Name = a.Book.Location.Name,
                 FloorNo = a.Book.Location.FloorNo,
                 ShelfNo = a.Book.Location.ShelfNo,
                 ShelfName = a.Book.Location.ShelfName

             })))
             .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.BookIssues.Select(a => new GetListCategoryListItemDto
             {
                 Id = a.Book.Category.Id,
                 Name = a.Book.Category.Name

             })));





        CreateMap<IPaginate<Member>, GetListResponse<GetListMemberListItemDto>>().ReverseMap();
        CreateMap<IPaginate<Member>, GetListResponse<GetByIdMemberResponse>>().ReverseMap();
    }
}