using Application.Features.Catalogs.Commands.Create;
using Application.Features.Catalogs.Commands.Delete;
using Application.Features.Catalogs.Commands.Update;
using Application.Features.Catalogs.Queries.GetById;
using Application.Features.Catalogs.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Catalogs.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Catalog, CreateCatalogCommand>().ReverseMap();
        CreateMap<Catalog, CreatedCatalogResponse>().ReverseMap();
        CreateMap<Catalog, UpdateCatalogCommand>().ReverseMap();
        CreateMap<Catalog, UpdatedCatalogResponse>().ReverseMap();
        CreateMap<Catalog, DeleteCatalogCommand>().ReverseMap();
        CreateMap<Catalog, DeletedCatalogResponse>().ReverseMap();
        CreateMap<Catalog, GetByIdCatalogResponse>().ReverseMap();
        CreateMap<Catalog, GetListCatalogListItemDto>().ReverseMap();
        CreateMap<IPaginate<Catalog>, GetListResponse<GetListCatalogListItemDto>>().ReverseMap();
    }
}