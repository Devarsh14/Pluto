using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCompanyParts
    {
        public long CompanyPartId { get; set; }
        public long MaterialId { get; set; }
        public long CompanyId { get; set; }
        public bool IsPrincipleCompanyId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
