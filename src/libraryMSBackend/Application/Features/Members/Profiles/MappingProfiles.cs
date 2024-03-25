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
using Application.Features.Authors.Queries.GetList;

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
              .Select(a => new GetListBookListItemDto
              {
                  Id = a.BookId,
                  ISBNCode = a.Book.ISBNCode,
                  BookTitle = a.Book.BookTitle,
                  BookEdition = a.Book.BookEdition,
                  ReleaseDate = a.Book.ReleaseDate,
                  Status = a.Book.Status,
                  CategoryName = a.Book.Category.Name,
                  PublisherName = a.Book.Publisher.Name,
                  Location = new GetListLocationListItemDto
                  {
                      Id = a.Book.Id,
                      Name = a.Book.Location.Name,
                      ShelfName = a.Book.Location.ShelfName,
                      FloorNo = a.Book.Location.FloorNo,
                      ShelfNo = a.Book.Location.ShelfNo
                  },
                  Authors = new List<GetListAuthorListItemDto>
                  {
                      new GetListAuthorListItemDto
                      {

                      }
                  }
              })));
        CreateMap<IPaginate<Member>, GetListResponse<GetListMemberListItemDto>>().ReverseMap();
    }
}