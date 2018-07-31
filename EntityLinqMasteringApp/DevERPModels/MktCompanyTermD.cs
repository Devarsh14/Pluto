using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyTermD
    {
        public int CompanyTermDetId { get; set; }
        public int CompanyId { get; set; }
        public int TermCategoryId { get; set; }
        public int TermId { get; set; }
        public bool IsSalesTerm { get; set; }
        public bool IsPurchaseTerm { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
