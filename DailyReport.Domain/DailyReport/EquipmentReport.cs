using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public class EquipmentReport
    {
        public Guid Id { get; set; }


        public string EquipmentType { get; set; } = string.Empty;

        public string Quanity { get; set; } = string.Empty;

        public int WorkingHour { get; set; }

        public int IdleHour { get; set; }

        public Guid DailyReportId { get; set; }
    }
}
