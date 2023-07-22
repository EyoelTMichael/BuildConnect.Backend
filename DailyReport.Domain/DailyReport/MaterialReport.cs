using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public class MaterialReport
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public string TypeOfMaterial { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public Guid UnitOfMeasureId { get; set; }

        public string Delivered { get; set; } = string.Empty;

        public string Remark { get; set; } = string.Empty;

        public DateTime ToDate { get; set; }

        public Guid DailyReportId { get; set; }

    }
}
