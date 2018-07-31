using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCustomerCategoryM
    {
        public short CustomerCategoryId { get; set; }
        public string CustomerCategory { get; set; }
        public short? GroupId { get; set; }
        public byte CurrencyId { get; set; }
        public byte? RateUnit { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
