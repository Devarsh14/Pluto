using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktAutoQuoteSetupChargesM
    {
        public int AutoquoteSetupChargesId { get; set; }
        public int CustomerCategoryId { get; set; }
        public int BandId { get; set; }
        public int SetupCharge { get; set; }
        public byte CurrencyId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
