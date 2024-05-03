using Application.Features.Members.Commands.Create;
using Application.Features.Members.Commands.Delete;
using Application.Features.Members.Commands.Update;
using Application.Features.Members.Queries.GetById;
using Application.Features.Members.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.Authors.Queries.GetList;
using System.Linq;
using Application.Features.Magazines.Queries.FilterSearch;
using Application.Features.Members.Queries.FilterSearch;

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
              .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookIssues
              .Select(m => new GetListBookListItemDto
              {
                  Id = m.BookId,
                  ISBNCode = m.Book.ISBNCode,
                  BookTitle = m.Book.BookTitle,
                  BookEdition = m.Book.BookEdition,
                  ReleaseDate = m.Book.ReleaseDate,
                  Status = m.Book.Status.ToString(),
                  CategoryName = m.Book.Category.Name,
                  PublisherName = m.Book.Publisher.Name,
                  ImageUrl=m.Book.ImageUrl,
                  PageCount = m.Book.PageCount,   
                  Locations = new GetListLocationListItemDto
                  {
                      Id = m.Book.Id,
                      Name = m.Book.Location.Name,
                      ShelfName = m.Book.Location.ShelfName,
                      FloorNo = m.Book.Location.FloorNo,
                      ShelfNo = m.Book.Location.ShelfNo
                  },
                  Authors = m.Book.BookAuthors.Select(ba => new GetListAuthorListItemDto
                  {
                      Id = ba.Author.Id,
                      FirstName = ba.Author.FirstName,
                      LastName = ba.Author.LastName
                  }).ToList()
              })));
        CreateMap<Member, GetByIdMemberResponse>()
             .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookIssues
             .Select(m => new GetListBookListItemDto
             {
                 Id = m.BookId,
                 ISBNCode = m.Book.ISBNCode,
                 BookTitle = m.Book.BookTitle,
                 BookEdition = m.Book.BookEdition,
                 ReleaseDate = m.Book.ReleaseDate,
                 Status = m.Book.Status.ToString(),
                 CategoryName = m.Book.Category.Name,
                 PageCount = m.Book.PageCount, 
                 ImageUrl=m.Book.ImageUrl,
                 PublisherName = m.Book.Publisher.Name,
                 Locations = new GetListLocationListItemDto
                 {
                     Id = m.Book.Id,
                     Name = m.Book.Location.Name,
                     ShelfName = m.Book.Location.ShelfName,
                     FloorNo = m.Book.Location.FloorNo,
                     ShelfNo = m.Book.Location.ShelfNo
                 },
                 Authors = m.Book.BookAuthors.Select(ba => new GetListAuthorListItemDto
                 {
                     Id = ba.Author.Id,
                     FirstName = ba.Author.FirstName,
                     LastName = ba.Author.LastName
                 }).ToList()
             })));
        CreateMap<Member, SearchMembersResponse>()
         .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
         .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookIssues
             .Select(m => new GetListBookListItemDto
             {
                 Id = m.BookId,
                 ISBNCode = m.Book.ISBNCode,
                 BookTitle = m.Book.BookTitle,
                 BookEdition = m.Book.BookEdition,
                 ReleaseDate = m.Book.ReleaseDate,
                 Status = m.Book.Status.ToString(),
                 CategoryName = m.Book.Category.Name,
                 PublisherName = m.Book.Publisher.Name,
                 ImageUrl= m.Book.ImageUrl,
                 PageCount=m.Book.PageCount,
                 Locations = new GetListLocationListItemDto
                 {
                     Id = m.Book.Id,
                     Name = m.Book.Location.Name,
                     ShelfName = m.Book.Location.ShelfName,
                     FloorNo = m.Book.Location.FloorNo,
                     ShelfNo = m.Book.Location.ShelfNo
                 },
                 Authors = m.Book.BookAuthors.Select(ba => new GetListAuthorListItemDto
                 {
                     Id = ba.Author.Id,
                     FirstName = ba.Author.FirstName,
                     LastName = ba.Author.LastName
                 }).ToList()
             })));


        CreateMap<IPaginate<Member>, GetListResponse<GetListMemberListItemDto>>().ReverseMap();
    }
}