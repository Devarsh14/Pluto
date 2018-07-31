using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldPrdSubsidiaryProductTypeD
    {
        public long SubsidiaryProductTypeId { get; set; }
        public long ProductId { get; set; }
        public short VersionNum { get; set; }
        public byte DependencyProductTypeId { get; set; }
        public long UsedQty { get; set; }
        public long UsedQtyArray { get; set; }
        public long UsedQtyPanel { get; set; }
        public DateTime UpdatedDt { get; set; }
    }
}
