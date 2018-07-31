using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktQuotationParametersD
    {
        public int QuotationRateListParameterId { get; set; }
        public int QuotationRateListId { get; set; }
        public int ParameterId { get; set; }
        public int ParameterOptionId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
