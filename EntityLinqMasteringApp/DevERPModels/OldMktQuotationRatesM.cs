using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuotationRatesM
    {
        public int QuotationRateListId { get; set; }
        public int CustomerId { get; set; }
        public int CustomerCategoryId { get; set; }
        public int CurrencyId { get; set; }
        public int RateUnitId { get; set; }
        public DateTime ValidityDt { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
