using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public class DailyWorkProgressReport
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string TypeOfWork { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public Guid UnitOfMeasureId { get; set; }

        public int Quantity { get; set; }

        public string Remark { get; set; } = string.Empty;

        public Guid DailyReportId { get; set; }


    }
}
