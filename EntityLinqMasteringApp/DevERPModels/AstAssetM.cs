using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstAssetM
    {
        public short MachineId { get; set; }
        public string MachineName { get; set; }
        public int MachineTypeId { get; set; }
        public byte? ProcessStepId { get; set; }
        public short SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPhoneNum { get; set; }
        public string EmailId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public double? PurchasePriceInRs { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? InstallationDate { get; set; }
        public DateTime? WarrantyTillDate { get; set; }
        public short? MaintenancePeriodMonths { get; set; }
        public short? MaintenancePeriodDays { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public long? SqMforMaintenance { get; set; }
        public long? SqMdoneAfterMaintenance { get; set; }
        public long? SqMdonetotal { get; set; }
        public int? IdealProductionPerHour { get; set; }
        public int? MaxNoOfBoardsPerHour { get; set; }
        public int? MaxNoOfWorkOrdersPerHour { get; set; }
        public string MachineSetupTime { get; set; }
        public string AvailabilityPerDay { get; set; }
        public string Notes { get; set; }
        public int? PlantId { get; set; }
        public int? AreaId { get; set; }
        public int? LocationId { get; set; }
        public int OutputCount { get; set; }
        public int JobCount { get; set; }
        public int LedgerId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string MachineCode { get; set; }
        public string ElectricalDetails { get; set; }
        public string OfficePhoneNum { get; set; }
        public int IdealUtilizationPerHh { get; set; }
        public int IdealUtilizationPerMm { get; set; }
        public string MtncContectPersonName { get; set; }
        public string MtncPhoneNo { get; set; }
        public string MtncMobileNo { get; set; }
        public string MtncEmailId { get; set; }
        public long? CurrWorkOrderProcessId { get; set; }
        public string Status { get; set; }
        public double? RolePercentage { get; set; }
        public double? PercentRole1 { get; set; }
        public int AssetCategoryId { get; set; }
        public double? Budget { get; set; }
        public string BudgetType { get; set; }
        public double? UpperValue { get; set; }
        public double? ActualSpentAmt { get; set; }
        public double InitialSpentAmt { get; set; }
        public DateTime? YearofManufacture { get; set; }
        public DateTime? DateofStartofUse { get; set; }
        public int EmployeeId { get; set; }
        public string IdofAsset { get; set; }
        public double? TotalWorkDoneInProduction { get; set; }
        public int? TotalWorkDoneInProductionUnit { get; set; }
        public double? TotalWorkDoneInMeasurement { get; set; }
        public int? TotalWorkDoneInMeasurementUnit { get; set; }
        public int? OverdueAlertInDays { get; set; }
        public string OverdueAlertMobileNo { get; set; }
        public int? OverdueAlertforSupervisorInDays { get; set; }
        public string OverdueAlertforSupervisorMobileNo { get; set; }
    }
}
