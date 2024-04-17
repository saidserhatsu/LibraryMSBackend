using Application.Features.MagazineAuthors.Commands.Create;
using Application.Features.MagazineAuthors.Commands.Delete;
using Application.Features.MagazineAuthors.Commands.Update;
using Application.Features.MagazineAuthors.Queries.GetById;
using Application.Features.MagazineAuthors.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.MagazineAuthors.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<MagazineAuthor, CreateMagazineAuthorCommand>().ReverseMap();
        CreateMap<MagazineAuthor, CreatedMagazineAuthorResponse>().ReverseMap();
        CreateMap<MagazineAuthor, UpdateMagazineAuthorCommand>().ReverseMap();
        CreateMap<MagazineAuthor, UpdatedMagazineAuthorResponse>().ReverseMap();
        CreateMap<MagazineAuthor, DeleteMagazineAuthorCommand>().ReverseMap();
        CreateMap<MagazineAuthor, DeletedMagazineAuthorResponse>().ReverseMap();
        CreateMap<MagazineAuthor, GetByIdMagazineAuthorResponse>().ReverseMap();
        CreateMap<MagazineAuthor, GetListMagazineAuthorListItemDto>().ReverseMap();
        CreateMap<IPaginate<MagazineAuthor>, GetListResponse<GetListMagazineAuthorListItemDto>>().ReverseMap();
    }
}