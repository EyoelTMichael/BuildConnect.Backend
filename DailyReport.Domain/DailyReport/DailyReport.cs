using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public class DailyReport
    {
        public Guid Id { get; set; }

        public Guid SiteId { get; set; }

        public DateTime Date { get; set; }

        public string WeatherCondition { get; set; }

        public int InterruptedHr { get; set; }

        public List<StaffOnSite> StaffOnSiteReports { get; set; }

        public List<LabourForce> LabourForceReports { get; set; }

        public List<Equipment> EquipmentReports { get; set; }

        public List<Material> MaterialReports { get; set; }

        public List<DailyWorkProgressReport> DailyWorkProgressReports { get; set; }

        public string Remark { get; set; }

        public string OrderGivenToTheContractor { get; set; }

        public Guid UserId { get; set; }

    }
}
