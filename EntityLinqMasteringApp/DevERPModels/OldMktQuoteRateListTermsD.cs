using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuoteRateListTermsD
    {
        public int QuotationRateListTermId { get; set; }
        public int QuotationRateListId { get; set; }
        public int QuotationTermId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
