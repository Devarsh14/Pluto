using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAutoQuoteM
    {
        public int AutoQuoteId { get; set; }
        public string PartNum { get; set; }
        public string PartName { get; set; }
        public int CustomerId { get; set; }
        public string Version { get; set; }
        public int UnitId { get; set; }
        public int ProductTypeId { get; set; }
        public double Quantity { get; set; }
        public double QuotedRate { get; set; }
        public double Pcblength { get; set; }
        public double Pcbwidth { get; set; }
        public int PreferredMethod { get; set; }
        public string Comments { get; set; }
        public DateTime? ValidTillDt { get; set; }
        public DateTime DeliveryDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
