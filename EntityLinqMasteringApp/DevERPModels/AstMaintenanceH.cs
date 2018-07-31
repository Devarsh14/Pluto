using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstMaintenanceH
    {
        public int MachienmaintenanceHistoryId { get; set; }
        public int MachineId { get; set; }
        public int MachineMaintenanceId { get; set; }
        public DateTime? NextMaintenanceDt { get; set; }
        public double? ExpectedMaintenanceOutputUnit { get; set; }
        public int? ExpectedMaintenanceOutputUnitId { get; set; }
        public double? ExpectedMaintenanceReportingUnit { get; set; }
        public int? ExpectedMaintenanceReportingUnitId { get; set; }
        public int? ExpectedMaintenanceForJob { get; set; }
        public double? ActualMaintenanceOutputUnit { get; set; }
        public int? ActualMaintenanceOutputUnitId { get; set; }
        public double? ActualMaintenanceReportingUnit { get; set; }
        public int? ActualMaintenanceReportingUnitId { get; set; }
        public int? ActualMaintenanceForJob { get; set; }
        public double? Cost { get; set; }
        public double? PartCost { get; set; }
        public double? LabourCost { get; set; }
        public string NoofHoursForMaintenance { get; set; }
        public int? AttendedEmployeeId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? ExpectedMaintenanceForJob1 { get; set; }
        public short CurrencyId { get; set; }
        public short DefaultCurrencyId { get; set; }
        public double CurrencyExchangeRate { get; set; }
        public bool IsPaid { get; set; }
        public int PaidUsingLedgerId { get; set; }
        public bool IsSynched { get; set; }
        public long? VoucherId { get; set; }
        public short? ExpMaintenanceInNoOfHours { get; set; }
        public DateTime? ExpMaintenanceDtWithHours { get; set; }
        public short? ActualMaintenanceInNoOfHours { get; set; }
    }
}
