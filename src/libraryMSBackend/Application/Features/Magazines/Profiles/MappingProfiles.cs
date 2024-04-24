using Application.Features.Magazines.Commands.Create;
using Application.Features.Magazines.Commands.Delete;
using Application.Features.Magazines.Commands.Update;
using Application.Features.Magazines.Queries.GetById;
using Application.Features.Magazines.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Magazines.Queries.FilterSearch;
using Application.Features.Publishers.Queries.GetList;

namespace Application.Features.Magazines.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Magazine, CreateMagazineCommand>().ReverseMap();
        CreateMap<Magazine, CreatedMagazineResponse>().ReverseMap();
        CreateMap<Magazine, UpdateMagazineCommand>().ReverseMap();
        CreateMap<Magazine, UpdatedMagazineResponse>().ReverseMap();
        CreateMap<Magazine, DeleteMagazineCommand>().ReverseMap();
        CreateMap<Magazine, DeletedMagazineResponse>().ReverseMap();
        CreateMap<Magazine, GetByIdMagazineResponse>().ReverseMap();
        CreateMap<Magazine, GetListMagazineListItemDto>().ReverseMap();

        CreateMap<Magazine, SearchMagazinesResponse>()
             .ForMember(dest => dest.MagazineISSNCode, opt => opt.MapFrom(src => src.ISSNCode))
             .ForMember(dest => dest.MagazineTitle, opt => opt.MapFrom(src => src.MagazineTitle));


        CreateMap<IPaginate<Magazine>, GetListResponse<GetListMagazineListItemDto>>().ReverseMap();

    }
}