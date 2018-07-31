using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessStepMaintenanceH
    {
        public int ProcessMaintenanceHistoryId { get; set; }
        public int ProcessStepMaintenanceId { get; set; }
        public int ProcessStepId { get; set; }
        public double? ExpectedMaintnanceInOutputUnit { get; set; }
        public int? ExpectedMaintnanceInOutputUnitId { get; set; }
        public double? ExpectedMaintnanceInReportingUnit { get; set; }
        public int? ExpectedMaintnanceInReportingUnitId { get; set; }
        public int? ExpectedMaintnanceForJob { get; set; }
        public DateTime? NextMaintenanceDt { get; set; }
        public double? ActualMaintnanceInOutputUnit { get; set; }
        public double? ActualMaintnanceInReportingUnit { get; set; }
        public int? ActualMaintnanceForJob { get; set; }
        public double? Cost { get; set; }
        public double? PartCost { get; set; }
        public double? LabourCost { get; set; }
        public string NoofHoursForMaintenance { get; set; }
        public int? AttendedEmployeeId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short CurrencyId { get; set; }
        public short DefaultCurrencyId { get; set; }
        public double CurrencyExchangeRate { get; set; }
        public bool IsPaid { get; set; }
        public int PaidUsingLedgerId { get; set; }
        public short? ExpMaintenanceInNoOfHours { get; set; }
        public DateTime? ExpMaintenanceDtWithHours { get; set; }
        public short? ActualMaintenanceInNoOfHours { get; set; }
    }
}
