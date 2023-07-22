using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.Domain.DailyReport
{
    public interface IDailyReportRepository
    {
        Task<IEnumerable<DailyReport>> GetAllDailyReports(Guid siteId);

        void Add(DailyReport dailyReport);

        Task<DailyReport> GetDailyReportByDate(DateTime date);

        void Update(DailyReport dailyReport);

        void Delete(List<Guid> dailyReports);

        //Staff On Site Repository
        void AddStaffOnsite(StaffOnSiteReport staffOnSite);

        Task<StaffOnSiteReport> GetStaffOnSiteReport(Guid dailyReportId);

        void UpdateStaffOnSite(StaffOnSiteReport staffOnSite);

        void DeleteStaffOnSiteL(List<Guid> staffOnSiteId);

        // Equipment Report Repository 
        void AddEquipmentReport(EquipmentReport equipmentReport);

        Task<EquipmentReport> GetEquipmentReport(Guid dailyReportId);

        void UpdateEquipmentReport(EquipmentReport equipmentReport);

        void DeleteEquipmentReport(List<Guid> equipmentReportId);

        //Material Report Repository
        void AddMaterialReport(MaterialReport materialReport);

        Task<List<MaterialReport>> GetMaterialReport(Guid dailyReportId);

        void UpdateMaterialReport(MaterialReport materialReport);

        void DeleteMaterialReport(List<Guid> materialReportId);

        //DailyWorkProgressReport Repository
        void AddDailyWorkProgressReport(DailyWorkProgressReport materialReport);

        Task<DailyWorkProgressReport> GetDailyWorkProgressReport(Guid dailyReportId);

        void UpdateDailyWorkProgressReport(DailyWorkProgressReport materialReport);

        void DeleteDailyWorkProgressReport(List<Guid> materialReportId);
    
    }
}
