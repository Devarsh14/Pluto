using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuotationTermsM
    {
        public short QuotationTermId { get; set; }
        public string QuotationTerm { get; set; }
        public byte TermsCategoryId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public decimal AdvanceAmtPer { get; set; }
    }
}
