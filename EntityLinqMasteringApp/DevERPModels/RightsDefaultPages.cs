using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsDefaultPages
    {
        public int DefaultPageId { get; set; }
        public string Module { get; set; }
        public string DefaultPage { get; set; }
        public string PageTitle { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsAccounts { get; set; }
    }
}
