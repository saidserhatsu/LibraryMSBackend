using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FineDues.Queries.FilterSearch;
public class SearchFineDueResponse
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }

    public string BookIssueMemberFirstName { get; set; }
    public string BookIssueMemberLastName { get; set; }
    public string BookIssueBookBookTitle { get; set; }
    public string BookIssueReturnDate { get; set; }
}
