using Application.Features.FavoriteBooks.Commands.Create;
using Application.Features.FavoriteBooks.Commands.Delete;
using Application.Features.FavoriteBooks.Commands.Update;
using Application.Features.FavoriteBooks.Queries.GetById;
using Application.Features.FavoriteBooks.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.FavoriteBooks.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<FavoriteBook, CreateFavoriteBookCommand>().ReverseMap();
        CreateMap<FavoriteBook, CreatedFavoriteBookResponse>().ReverseMap();
        CreateMap<FavoriteBook, UpdateFavoriteBookCommand>().ReverseMap();
        CreateMap<FavoriteBook, UpdatedFavoriteBookResponse>().ReverseMap();
        CreateMap<FavoriteBook, DeleteFavoriteBookCommand>().ReverseMap();
        CreateMap<FavoriteBook, DeletedFavoriteBookResponse>().ReverseMap();
        CreateMap<FavoriteBook, GetByIdFavoriteBookResponse>().ReverseMap();
        CreateMap<FavoriteBook, GetListFavoriteBookListItemDto>().ReverseMap();
        CreateMap<IPaginate<FavoriteBook>, GetListResponse<GetListFavoriteBookListItemDto>>().ReverseMap();
    }
}