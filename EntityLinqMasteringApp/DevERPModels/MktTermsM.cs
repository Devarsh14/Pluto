using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktTermsM
    {
        public int TermId { get; set; }
        public string Term { get; set; }
        public byte TermsCategoryId { get; set; }
        public bool IsPurchaseTerm { get; set; }
        public bool IsSalesTerm { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public decimal AdvanceAmtPer { get; set; }
    }
}
