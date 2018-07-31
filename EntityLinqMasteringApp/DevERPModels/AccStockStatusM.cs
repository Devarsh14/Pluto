using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccStockStatusM
    {
        public int StockStatusId { get; set; }
        public DateTime StockStatusDt { get; set; }
        public double Amount { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public int VoucherId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
