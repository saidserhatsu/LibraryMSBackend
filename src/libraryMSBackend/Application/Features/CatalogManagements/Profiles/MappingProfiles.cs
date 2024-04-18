using Application.Features.CatalogManagements.Commands.Create;
using Application.Features.CatalogManagements.Commands.Delete;
using Application.Features.CatalogManagements.Commands.Update;
using Application.Features.CatalogManagements.Queries.GetById;
using Application.Features.CatalogManagements.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.CatalogManagements.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CatalogManagement, CreateCatalogManagementCommand>().ReverseMap();
        CreateMap<CatalogManagement, CreatedCatalogManagementResponse>().ReverseMap();
        CreateMap<CatalogManagement, UpdateCatalogManagementCommand>().ReverseMap();
        CreateMap<CatalogManagement, UpdatedCatalogManagementResponse>().ReverseMap();
        CreateMap<CatalogManagement, DeleteCatalogManagementCommand>().ReverseMap();
        CreateMap<CatalogManagement, DeletedCatalogManagementResponse>().ReverseMap();
        CreateMap<CatalogManagement, GetByIdCatalogManagementResponse>().ReverseMap();
        CreateMap<CatalogManagement, GetListCatalogManagementListItemDto>()
                .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.BookTitle))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Book.BookAuthors.First().Author.FirstName + " " + src.Book.BookAuthors.First().Author.LastName));
        CreateMap<IPaginate<CatalogManagement>, GetListResponse<GetListCatalogManagementListItemDto>>().ReverseMap();
    }
}