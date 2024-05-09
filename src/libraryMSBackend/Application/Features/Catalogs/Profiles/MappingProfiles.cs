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
using Application.Features.Categories.Queries.GetList;
using Application.Features.Publishers.Queries.GetList;
using System.Runtime.CompilerServices;
using Application.Features.EBooks.Queries.GetList;
using Application.Features.Categories.Queries.FilterSearch;
using Application.Features.Catalogs.Queries.FilterSearch;

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
        CreateMap<Catalog, GetByIdCatalogResponse>().ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Book != null)
                    .Select(cm => new GetListBookListItemDto
                    {
                        Id = cm.Book.Id,
                        ISBNCode = cm.Book.ISBNCode,
                        BookTitle = cm.Book.BookTitle,
                        BookEdition = cm.Book.BookEdition,
                        PageCount = cm.Book.PageCount,
                        ReleaseDate = cm.Book.ReleaseDate,
                        ImageUrl = cm.Book.ImageUrl,
                        Status = cm.Book.Status.ToString(),
                        CategoryName = cm.Book.Category.Name,
                        PublisherName = cm.Book.Publisher.Name,
                        Locations = new GetListLocationListItemDto
                        {
                            Id = cm.Book.Id,
                            Name = cm.Book.Location.Name,
                            ShelfName = cm.Book.Location.ShelfName,
                            FloorNo = cm.Book.Location.FloorNo,
                            ShelfNo = cm.Book.Location.ShelfNo
                        },

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
                        ISSNCode = cm.Magazine.ISSNCode,
                        MagazineTitle = cm.Magazine.MagazineTitle,
                        ReleaseDate = cm.Magazine.ReleaseDate,
                        PublisherId = cm.Magazine.PublisherId,
                        Number = cm.Magazine.Number,
                        CategoryId = cm.Book.Category.Id,
                        CategoryName = cm.Book.Category.Name,
                        PublisherName = cm.Book.Publisher.Name,



                    })))



                .ForMember(dest => dest.Materials, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Material != null)
                    .Select(cm => new GetListMaterialListItemDto
                    {
                        Id = cm.Material.Id,
                        Name = cm.Material.Name,
                        MaterialType = cm.Material.MaterialType.ToString(),
                        ReleaseDate = cm.Material.ReleaseDate,
                        CategoryId = cm.Book.Category.Id,
                        CategoryName = cm.Book.Category.Name,
                        PublisherId = cm.Book.Publisher.Id,
                        PublisherName = cm.Book.Publisher.Name

                    })));

        // Null referanslarla baþa çýkmak için NullSubstitute kullanarak varsayýlan deðerleri ekleyin
        CreateMap<Catalog, GetListCatalogListItemDto>()
                .ForMember(dest => dest.CatalogManagements, opt => opt.MapFrom(src => src.CatalogManagements
            .Where(cm => cm.Book != null) // Null referanslarý filtreleme
            .Select(cm => new GetListCatalogManagementListItemDto
            {
                Id = cm.Id,
                BookTitle = cm.Book.BookTitle , // Null kontrolü
            }).ToList() ?? new List<GetListCatalogManagementListItemDto>())) // Boþ liste kontrolü


              .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.CatalogManagements
                .Where(cm => cm.Book != null)
                .Select(cm => new GetListBookListItemDto
                {
                    Id = cm.Book.Id,
                    ISBNCode = cm.Book.ISBNCode ?? "N/A", // Null deðerlerle baþa çýkmak için NullSubstitute
                    BookTitle = cm.Book.BookTitle ?? "Unknown Title",
                    BookEdition = cm.Book.BookEdition,
                    PageCount = cm.Book.PageCount,
                    ReleaseDate = cm.Book.ReleaseDate,
                    ImageUrl = cm.Book.ImageUrl ?? "default_image.jpg",
                    Status = cm.Book.Status.ToString() ?? "Unknown",
                    CategoryName = cm.Book.Category.Name ?? "Unknown Category",
                    PublisherName = cm.Book.Publisher.Name ?? "Unknown Publisher",
                    Locations = new GetListLocationListItemDto
                    {
                        Id = cm.Book.Id,
                        Name = cm.Book.Location.Name ?? "Unknown Location",
                        ShelfName = cm.Book.Location.ShelfName ?? "N/A",
                        FloorNo = cm.Book.Location.FloorNo,
                        ShelfNo = cm.Book.Location.ShelfNo,
                    },
                    Authors = cm.Book.BookAuthors
                        .Where(ba => ba.Author != null)
                        .Select(ba => new GetListAuthorListItemDto
                        {
                            Id = ba.Author.Id,
                            FirstName = ba.Author.FirstName,
                            LastName = ba.Author.LastName
                        })
                        .ToList() ?? new List<GetListAuthorListItemDto>()
                }).ToList() ?? new List<GetListBookListItemDto>()) // Null kontrolü ve boþ liste
                )
                .ForMember(dest => dest.Magazines, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Magazine != null)
                    .Select(cm => new GetListMagazineListItemDto
                    {
                        Id = cm.Magazine.Id,
                        ISSNCode = cm.Magazine.ISSNCode ?? "Unknown",
                        MagazineTitle = cm.Magazine.MagazineTitle ?? "Unknown Magazine",
                        ReleaseDate = cm.Magazine.ReleaseDate,
                        PublisherId = cm.Magazine.PublisherId,
                        Number = cm.Magazine.Number,
                        CategoryId = cm.Magazine.Category.Id,
                        CategoryName = cm.Magazine.Category.Name ?? "Unknown Category",
                        PublisherName = cm.Magazine.Publisher.Name ?? "Unknown Publisher",
                    }).ToList() ?? new List<GetListMagazineListItemDto>()))

                .ForMember(dest => dest.Materials, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Material != null)
                    .Select(cm => new GetListMaterialListItemDto
                    {
                        Id = cm.Material.Id,
                        Name = cm.Material.Name ?? "Unknown Material",
                        MaterialType = cm.Material.MaterialType.ToString() ?? "Unknown Type",
                        ReleaseDate = cm.Material.ReleaseDate,
                        CategoryId = cm.Material.Category.Id,
                        CategoryName = cm.Material.Category.Name ?? "Unknown Category",
                        PublisherId = cm.Material.Publisher.Id,
                        PublisherName = cm.Material.Publisher.Name ?? "Unknown Publisher",
                    }).ToList() ?? new List<GetListMaterialListItemDto>()));

        CreateMap<Catalog, SearchCatalogsResponse>()
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));






        CreateMap<IPaginate<Catalog>, GetListResponse<GetListCatalogListItemDto>>().ReverseMap();
    }
}