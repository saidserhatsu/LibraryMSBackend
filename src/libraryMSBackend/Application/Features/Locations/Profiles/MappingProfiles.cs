using Application.Features.Locations.Commands.Create;
using Application.Features.Locations.Commands.Delete;
using Application.Features.Locations.Commands.Update;
using Application.Features.Locations.Queries.GetById;
using Application.Features.Locations.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Magazines.Queries.FilterSearch;
using Application.Features.Locations.Queries.FilterSearch;

namespace Application.Features.Locations.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Location, CreateLocationCommand>().ReverseMap();
        CreateMap<Location, CreatedLocationResponse>().ReverseMap();
        CreateMap<Location, UpdateLocationCommand>().ReverseMap();
        CreateMap<Location, UpdatedLocationResponse>().ReverseMap();
        CreateMap<Location, DeleteLocationCommand>().ReverseMap();
        CreateMap<Location, DeletedLocationResponse>().ReverseMap();
        CreateMap<Location, GetByIdLocationResponse>().ReverseMap();
        CreateMap<Location, GetListLocationListItemDto>().ReverseMap();

        CreateMap<Location, SearchLocationsResponse>()
         .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
         .ForMember(dest => dest.ShelfName, opt => opt.MapFrom(src => src.ShelfName));

        CreateMap<IPaginate<Location>, GetListResponse<GetListLocationListItemDto>>().ReverseMap();
    }
}