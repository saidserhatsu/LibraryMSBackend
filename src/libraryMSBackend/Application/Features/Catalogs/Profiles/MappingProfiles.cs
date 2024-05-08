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


                .ForMember(dest => dest.EBooks, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.EBook != null)
                    .Select(cm => new GetListEBookListItemDto
                    {
                        Id=cm.EBook.Id,
                        CategoryId=cm.EBook.CategoryId, 
                        CategoryName = cm.EBook.Category.Name,
                        PageCount = cm.EBook.PageCount,
                        ReleaseDate=cm.EBook.ReleaseDate,
                        EBookTitle = cm.EBook.EBookTitle ?? string.Empty,
                        ISBNCode = cm.EBook.ISBNCode ?? string.Empty,
                        FileUrl = cm.EBook.FileUrl ?? string.Empty,
                        ImageUrl = cm.EBook.ImageUrl ?? string.Empty,
                        AuthorName = cm.EBook.AuthorName ?? string.Empty,
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

        CreateMap<Catalog, GetListCatalogListItemDto>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Book != null)
                    .Select(cm => new GetListBookListItemDto
                    {
                        Id = cm.Book.Id,
                        ISBNCode = cm.Book.ISBNCode,
                        BookTitle = cm.Book.BookTitle,
                        BookEdition=cm.Book.BookEdition,
                        PageCount=cm.Book.PageCount,
                        ReleaseDate=cm.Book.ReleaseDate,
                        ImageUrl=cm.Book.ImageUrl,
                        Status=cm.Book.Status.ToString(),
                        CategoryName=cm.Book.Category.Name,
                        PublisherName=cm.Book.Publisher.Name,
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
                        ISSNCode=cm.Magazine.ISSNCode,
                        MagazineTitle = cm.Magazine.MagazineTitle,
                        ReleaseDate = cm.Magazine.ReleaseDate,
                        PublisherId=cm.Magazine.PublisherId,
                        Number=cm.Magazine.Number,
                        CategoryId = cm.Book.Category.Id,
                        CategoryName = cm.Book.Category.Name,
                        PublisherName = cm.Book.Publisher.Name,
                      


                    })))

            
                .ForMember(dest => dest.EBooks, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.EBook != null)
                    .Select(cm => new GetListEBookListItemDto
                    {
                        Id = cm.EBook.Id,
                        CategoryId = cm.EBook.CategoryId,
                        CategoryName = cm.EBook.Category.Name,
                        PageCount = cm.EBook.PageCount,
                        ReleaseDate = cm.EBook.ReleaseDate,
                        EBookTitle = cm.EBook.EBookTitle ?? string.Empty,
                        ISBNCode = cm.EBook.ISBNCode ?? string.Empty,
                        FileUrl = cm.EBook.FileUrl ?? string.Empty,
                        ImageUrl = cm.EBook.ImageUrl ?? string.Empty,
                        AuthorName=cm.EBook.AuthorName ?? string.Empty,
                    })))

                .ForMember(dest => dest.Materials, opt => opt.MapFrom(src => src.CatalogManagements
                    .Where(cm => cm.Material != null)
                    .Select(cm => new GetListMaterialListItemDto
                    {
                        Id = cm.Material.Id,
                        Name = cm.Material.Name,
                        MaterialType = cm.Material.MaterialType.ToString(),
                        ReleaseDate=cm.Material.ReleaseDate,
                        CategoryId = cm.Book.Category.Id,
                        CategoryName = cm.Book.Category.Name,
                        PublisherId= cm.Book.Publisher.Id, 
                        PublisherName = cm.Book.Publisher.Name

                    })));









        CreateMap<IPaginate<Catalog>, GetListResponse<GetListCatalogListItemDto>>().ReverseMap();
    }
}