using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuotationBaseRatesD
    {
        public int QuotationRateListBaseRateId { get; set; }
        public int QuotationRateListDetailsId { get; set; }
        public int ProudctTypeId { get; set; }
        public string BaseRate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
