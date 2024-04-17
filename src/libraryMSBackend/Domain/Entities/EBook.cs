using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class EBook : Entity<Guid>
{
    public string FileUrl { get; set; }
    public Guid? BookId { get; set; }

    public virtual Book? Book { get; set; }
}
