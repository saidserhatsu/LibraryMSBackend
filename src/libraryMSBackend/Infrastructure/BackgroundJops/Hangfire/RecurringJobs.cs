using Application.Services.FineDues;
using Application.Services.RecurringJops;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BackgroundJops.Hangfire;
/// <summary>
/// RecurringJobs
/// </summary>
public static class RecurringJobs
{
    //Çok kez (tekrarlı işler) ve belirtilmiş CRON süresince çalışır.
    [Obsolete]
    public static void CalculateMemberDebt()
    {
        RecurringJob.RemoveIfExists(nameof(FineDueManager));
        RecurringJob.AddOrUpdate<FineDueManager>(
            nameof(FineDueManager) ,
            job => job.Process(),
            "45 20 * * *",
            TimeZoneInfo.Local);
        
    }

  
}
