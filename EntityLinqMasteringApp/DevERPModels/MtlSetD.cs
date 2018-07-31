using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSetD
    {
        public int SetDetailId { get; set; }
        public int SetId { get; set; }
        public int MaterialId { get; set; }
        public double RecommandedQty { get; set; }
        public bool IsVariantSet { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short VariantOrder { get; set; }
    }
}
