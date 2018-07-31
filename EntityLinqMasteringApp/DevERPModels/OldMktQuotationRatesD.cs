using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuotationRatesD
    {
        public int QuotationRateListDetailsId { get; set; }
        public int QuotationRateListId { get; set; }
        public int AutoQuoteBandId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
