using Application.Features.EBooks.Commands.Create;
using Application.Features.EBooks.Commands.Delete;
using Application.Features.EBooks.Commands.Update;
using Application.Features.EBooks.Queries.GetById;
using Application.Features.EBooks.Queries.GetList;
using Application.Features.EBooks.Queries.FilterSearch;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Books.Queries.FilterSearch;

namespace Application.Features.EBooks.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // EBook ve komutlar arasýnda eþleme
            CreateMap<EBook, CreateEBookCommand>().ReverseMap();
            CreateMap<EBook, CreatedEBookResponse>().ReverseMap();
            CreateMap<EBook, UpdateEBookCommand>().ReverseMap();
            CreateMap<EBook, UpdatedEBookResponse>().ReverseMap();
            CreateMap<EBook, DeleteEBookCommand>().ReverseMap();
            CreateMap<EBook, DeletedEBookResponse>().ReverseMap();

            // EBook ve yanýtlar arasýnda eþleme
            CreateMap<EBook, GetByIdEBookResponse>().ReverseMap();
            CreateMap<EBook, GetListEBookListItemDto>().ReverseMap();
            CreateMap<EBook, SearchEbookResponse>() // Yeni eþleme
                .ForMember(dest => dest.EBookTitle, opt => opt.MapFrom(src => src.EBookTitle))
                .ForMember(dest => dest.ISBNCode, opt => opt.MapFrom(src => src.ISBNCode));

            // IPaginate ile eþlemeler
            CreateMap<IPaginate<EBook>, GetListResponse<GetListEBookListItemDto>>().ReverseMap();
            CreateMap<IPaginate<EBook>, GetListResponse<SearchEbookResponse>>().ReverseMap(); // Farklý türler için eþleme
        }
    }
}