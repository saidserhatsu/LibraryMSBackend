using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class FinePayment : Entity<Guid>
{
    public decimal PaymentAmount { get; set; }
    public Guid MemberId { get; set; }

    public virtual Member Member { get; set; }
}
