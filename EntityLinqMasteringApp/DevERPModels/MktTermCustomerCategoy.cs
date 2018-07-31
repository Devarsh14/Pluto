using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktTermCustomerCategoy
    {
        public int CustomerTermId { get; set; }
        public int CustomerCategoryId { get; set; }
        public byte TermsCategoryId { get; set; }
        public byte TermId { get; set; }
        public decimal AdvanceAmtPer { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
