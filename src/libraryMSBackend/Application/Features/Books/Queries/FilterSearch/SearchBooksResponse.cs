using Application.Features.Authors.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;
using Application.Features.MaterialAuthors.Queries.GetList;
using Application.Features.Materials.Queries.GetList;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Application.Features.Books.Queries.FilterSearch;
public class SearchBooksResponse
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
   
    public List<GetListAuthorListItemDto> Authors { get; set; }
    public List<GetListMaterialAuthorListItemDto> Materials { get; set; }
    public List<GetListMagazineListItemDto> Magazines { get; set; }
    public GetListLocationListItemDto Location { get; set; }
}
