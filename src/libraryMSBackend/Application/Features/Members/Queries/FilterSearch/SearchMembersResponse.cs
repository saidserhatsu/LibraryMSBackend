using Application.Features.Books.Queries.GetList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Members.Queries.FilterSearch;
public class SearchMembersResponse
{
    public string Email { get; set; }

    public List<GetListBookListItemDto> Books { get; set; }
}

