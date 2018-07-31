using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstMarketValue
    {
        public int MarketValueId { get; set; }
        public double MarketValue { get; set; }
        public int MachineId { get; set; }
        public DateTime ObservedDate { get; set; }
        public short CreatedUserId { get; set; }
    }
}
