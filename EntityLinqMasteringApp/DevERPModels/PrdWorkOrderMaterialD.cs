using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMaterialD
    {
        public long WorkOrderMaterialDetId { get; set; }
        public long WorkOrderId { get; set; }
        public long? ProductMaterialUsageId { get; set; }
        public long? ProductSubAssemblyId { get; set; }
        public long? ProductByProductId { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public short MaterialBrandId { get; set; }
        public short CompletedTillProcessId { get; set; }
        public short ProcessStepId { get; set; }
        public bool ExpectFromPrevProcess { get; set; }
        public double? NumeratorExpQty { get; set; }
        public short? NumeratorExpQtyUnitId { get; set; }
        public double? DenominatorExpQty { get; set; }
        public short? DenominatorExpQtyUnitId { get; set; }
        public double? ExpQtyMaterialUsagePerProcessOutputQty { get; set; }
        public double? NumeratorExpProductionQty { get; set; }
        public short? NumeratorExpProductionQtyUnitId { get; set; }
        public double? DenominatorExpProductionQty { get; set; }
        public short? DenominatorExpProductionQtyUnitId { get; set; }
        public short ActualExpQtyMaterialUsageUnitId { get; set; }
        public double? OriginalExpQtyMaterialUsage { get; set; }
        public double? ActualExpQtyMaterialUsage { get; set; }
        public double? RemainingActualExpQtyMaterialUsage { get; set; }
        public double? OriginalExpProductionQty { get; set; }
        public double? ActualExpProductionQty { get; set; }
        public double? RemainingActualExpProductionQty { get; set; }
        public double IssuedQty { get; set; }
        public double ActualUsedQtyMaterialUsage { get; set; }
        public double? ActualProductionQty { get; set; }
        public double? ReceivedInStoreQty { get; set; }
        public double? TransferredToOtherJobQty { get; set; }
        public double? ReceivedFromOtherJobQty { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsProvidedByCust { get; set; }
        public double? WorkOrderQtyInPoaunit { get; set; }
        public double? WorkOrderQtyInProductionQtyUnit { get; set; }
        public double? WorkOrderQtyInSkunit { get; set; }
        public bool IsRawMaterial { get; set; }
        public bool IsRecoverableRawMaterial { get; set; }
        public bool IsSubAssembly { get; set; }
        public bool IsByProduct { get; set; }
        public bool IsSemiProcessed { get; set; }
        public bool IsFinalProduct { get; set; }
        public bool IsOtherProduct { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double DefaultInventoryRate { get; set; }
        public bool IsScrap { get; set; }
    }
}
