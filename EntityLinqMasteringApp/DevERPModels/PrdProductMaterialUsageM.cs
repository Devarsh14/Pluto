using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductMaterialUsageM
    {
        public long ProductMaterialUsageId { get; set; }
        public long ProductId { get; set; }
        public short VersionNum { get; set; }
        public int MaterialTypeId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public int? MaterialBrandId { get; set; }
        public short? ProcessStepId { get; set; }
        public double? NumeratorExpQty { get; set; }
        public short? NumeratorExpQtyUnitId { get; set; }
        public double? DenominatorExpQty { get; set; }
        public short? DenominatorExpQtyUnitId { get; set; }
        public bool IsProvidedByCust { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool? IsRecoverableRawMaterial { get; set; }
        public double? NumeratorExpRecoverQty { get; set; }
        public short? NumeratorExpRecoverQtyUnitId { get; set; }
        public double? DenominatorExpRecoverQty { get; set; }
        public short? DenominatorExpRecoverQtyUnitId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? MaterialSubCategoryProductTypeIdOld { get; set; }
        public double? ActualExpQtyOld { get; set; }
        public int? CustomerIdOld { get; set; }
        public short? QtyUnitIdOld { get; set; }
        public short? QtySunitIdOld { get; set; }
        public int? BasisIdOld { get; set; }
        public int? BasisAreaUnitIdOld { get; set; }
    }
}
