using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlOnlinePrice
    {
        public long OnlinePriceId { get; set; }
        public long ItemId { get; set; }
        public int SetId { get; set; }
        public short CurrencyId { get; set; }
        public double Price { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
