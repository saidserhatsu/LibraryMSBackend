using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EBooks.Queries.FilterSearch;
public class SearchEbookResponse
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string FileUrl { get; set; }
    public string ImageUrl { get; set; }
}
