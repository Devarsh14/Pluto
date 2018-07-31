using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktQuotationTermsD
    {
        public long QuotationTermDetId { get; set; }
        public short QuotationTermId { get; set; }
        public long QuotationId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
