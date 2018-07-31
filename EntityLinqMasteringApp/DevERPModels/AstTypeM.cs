using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstTypeM
    {
        public int MachineTypeId { get; set; }
        public int AssetCategoryId { get; set; }
        public short? GroupId { get; set; }
        public string MachineTypeName { get; set; }
        public string MachineTypeCode { get; set; }
        public int? LeadTime { get; set; }
        public double? MinRate { get; set; }
        public double? MaxRate { get; set; }
        public bool IsUpgradable { get; set; }
        public string Description { get; set; }
        public int? OverdueAlertInDays { get; set; }
        public string OverdueAlertMobileNo { get; set; }
        public int? OverdueAlertforSupervisorInDays { get; set; }
        public string OverdueAlertforSupervisorMobileNo { get; set; }
        public bool IsMachine { get; set; }
        public int OutputUnitId { get; set; }
        public int MaintenanceBasisId { get; set; }
        public int ReportingUnitCategoryId { get; set; }
        public int MaintenanceBasisOnReportingUnitId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
