using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyRecordD
    {
        public int CompanyRecordId { get; set; }
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
