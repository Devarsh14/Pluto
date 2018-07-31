using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderSeries
    {
        public long WorkOrderSeriesId { get; set; }
        public long? WorkOrderFinishedGoodDetId { get; set; }
        public long? WorkOrderId { get; set; }
        public int? ProductId { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int? StartNum { get; set; }
        public int EndNum { get; set; }
        public long? SeriesQty { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
