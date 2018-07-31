using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCustomerCategoryTaxD
    {
        public long CustomerCategoryTaxId { get; set; }
        public int CustomerCategoryId { get; set; }
        public int ClassificationId { get; set; }
        public int TaxId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
