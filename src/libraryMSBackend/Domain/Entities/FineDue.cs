using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class FineDue : Entity<Guid>
{
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }


    public virtual BookIssue BookIssue { get; set; }
}
