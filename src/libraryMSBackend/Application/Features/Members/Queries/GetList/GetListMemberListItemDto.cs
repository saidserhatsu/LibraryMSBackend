using Application.Features.Authors.Queries.GetById;
using Application.Features.BookAuthors.Queries.GetById;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetList;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using Application.Features.Locations.Queries.GetById;
using Application.Features.Locations.Queries.GetList;
using Application.Features.Publishers.Queries.GetById;
using Application.Features.Publishers.Queries.GetList;
using Domain.Enums;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Members.Queries.GetList;

public class GetListMemberListItemDto : IDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }




    public ICollection<GetListBookListItemDto> Books { get; set; }
    public ICollection<GetListLocationListItemDto> Locations { get; set; }
    public ICollection<GetListCategoryListItemDto> Categories { get; set; }
    public ICollection<GetListPublisherListItemDto> Publishers { get; set; }

}