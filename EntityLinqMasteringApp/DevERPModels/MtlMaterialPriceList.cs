using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlMaterialPriceList
    {
        public long MaterialPriceListId { get; set; }
        public int CntRangeId { get; set; }
        public long MaterialId { get; set; }
        public double CounterFromRange { get; set; }
        public double CounterToRange { get; set; }
        public int? CounterUnitId { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
