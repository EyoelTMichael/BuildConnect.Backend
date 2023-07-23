using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public class StaffOnSiteReport
    {
        public Guid Id { get; set; }

        public Guid LookupId { get; set; }

        public int Quantity { get; set; }

        public Guid DailyReportId { get; set; }

    }
}
