using Application.Features.Authors.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;
using Application.Features.MaterialAuthors.Queries.GetList;
using Application.Features.Publishers.Queries.GetList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Magazines.Queries.FilterSearch;
public class SearchMagazinesResponse
{
    public string MagazineTitle { get; set; }
    public string MagazineISSNCode { get; set; }
    public string PublisherName { get; set; }
    public string CategoryName { get; set; }



}
