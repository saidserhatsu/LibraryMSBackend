using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class MemberSetting : Entity<int>
{
    public string UiTheme { get; set; } = "light";
    public string Language { get; set; } = "en";
    public Guid MemberId { get; set; }
    public virtual Member Member { get; set; }
}
