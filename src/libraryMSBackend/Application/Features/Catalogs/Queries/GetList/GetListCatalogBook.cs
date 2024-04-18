using Application.Features.Authors.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Domain.Enums;
using NArchitecture.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Catalogs.Queries.GetList;
public class GetListCatalogBook :IDto
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public string CategoryName { get; set; }


    public List<GetListAuthorListItemDto> Authors { get; set; }
}
