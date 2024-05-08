using Application.Features.Authors.Queries.GetList;
using Application.Features.BookReservations.Queries.GetList;
using Application.Features.Books.Queries.GetList;
using Application.Features.FavoriteBooks.Queries.GetList;
using Application.Features.FineDues.Queries.GetList;
using Application.Features.FinePayments.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.Members.Commands.Create;
using Application.Features.Members.Commands.Delete;
using Application.Features.Members.Commands.Update;
using Application.Features.Members.Queries.FilterSearch;
using Application.Features.Members.Queries.GetById;
using Application.Features.Members.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

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
            .ForMember(dest => dest.FinePayments, opt =>
        opt.MapFrom(src => src.FinePayments != null
            ? src.FinePayments.Select(fp => new GetListFinePaymentListItemDto
            {
                Id = fp.Id,
                PaymentAmount = fp.PaymentAmount,
                MemberId = fp.MemberId,
                MemberFirstName = fp.Member.FirstName,
                MemberLastName = fp.Member.LastName,
                MemberEmail = fp.Member.Email
            }).ToList()
            : new List<GetListFinePaymentListItemDto>()))


            .ForMember(dest => dest.FineDues, opt =>
        opt.MapFrom(src => src.BookIssues
            .SelectMany(bi => bi.FineDues, (bi, fd) => new GetListFineDueListItemDto
            {
                Id = fd.Id,
                FineTotal = fd.FineTotal,
                BookIssueId = fd.BookIssueId,
                FineDate = fd.FineDate,
                BookIssueMemberFirstName = bi.Member.FirstName,
                BookIssueMemberLastName = bi.Member.LastName,
                BookIssueBookBookTitle = bi.Book.BookTitle,
                BookIssueReturnDate = bi.ReturnDate.ToString() ?? "Unknown"
            }).ToList()))


            .ForMember(dest => dest.Favorites, opt =>
        opt.MapFrom(src => src.FavoriteBooks != null ?
        src.FavoriteBooks.Select(fb => new GetListFavoriteBookListItemDto
        {
            Id = fb.Id,
            BookId = fb.BookId,
            BookBookTitle = fb.Book.BookTitle,
            MemberId = fb.MemberId,
            MemberFirstName = fb.Member.FirstName,
            MemberLastName = fb.Member.LastName
        }).ToList() : new List<GetListFavoriteBookListItemDto>()))
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
                  ImageUrl = m.Book.ImageUrl,
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
                 ImageUrl = m.Book.ImageUrl,
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
             })))
             .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.BookReservations.Select(r => new GetListBookReservationListItemDto
             {
                 Id = r.Id,
                 BookId = r.BookId,
                 MemberId = r.MemberId,
                 MemberFirstName = r.Member.FirstName,
                 MemberLastName = r.Member.LastName,
                 BookBookTitle = r.Book.BookTitle,
                 BookStatus = r.Book.Status.ToString(),
                 RequestDate = r.RequestDate
             }).ToList()));
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
                 ImageUrl = m.Book.ImageUrl,
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


        CreateMap<IPaginate<Member>, GetListResponse<GetListMemberListItemDto>>().ReverseMap();
    }
}