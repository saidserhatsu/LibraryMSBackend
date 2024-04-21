using Application.Features.Catalogs.Commands.Create;
using Application.Features.Catalogs.Commands.Delete;
using Application.Features.Catalogs.Commands.Update;
using Application.Features.Catalogs.Queries.GetById;
using Application.Features.Catalogs.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Authors.Queries.GetList;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.CatalogManagements.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;
using Application.Features.Materials.Queries.GetList;

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
        CreateMap<Catalog, GetListCatalogListItemDto>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Book != null)
                    .Select(cm => new GetListBookListItemDto
                    {
                        Id = cm.Book.Id,
                        ISBNCode = cm.Book.ISBNCode,
                        BookTitle = cm.Book.BookTitle,
                        Authors = cm.Book.BookAuthors.Select(ba => new GetListAuthorListItemDto
                        {
                            Id = ba.Author.Id,
                            FirstName = ba.Author.FirstName,
                            LastName = ba.Author.LastName

                        }).ToList()


                    })))

                .ForMember(dest => dest.Magazines, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Magazine != null)
                    .Select(cm => new GetListMagazineListItemDto
                    {
                        Id = cm.Magazine.Id,
                        ISSNCode=cm.Magazine.ISSNCode,
                        MagazineTitle = cm.Magazine.MagazineTitle,
                        ReleaseDate = cm.Magazine.ReleaseDate,
                        PublisherId=cm.Magazine.PublisherId,
                        Number=cm.Magazine.Number
                        


                    })))
                .ForMember(dest => dest.Materials, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Material != null)
                    .Select(cm => new GetListMaterialListItemDto
                    {
                        Id = cm.Material.Id,
                        Name = cm.Material.Name,
                        MaterialType = cm.Material.MaterialType,
                    })));









        CreateMap<IPaginate<Catalog>, GetListResponse<GetListCatalogListItemDto>>().ReverseMap();
    }
}