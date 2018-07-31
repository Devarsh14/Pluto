using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class TermsCategoryM
    {
        public short TermsCategoryId { get; set; }
        public string TermsCategoryName { get; set; }
        public bool IsAdvance { get; set; }
        public bool? IsAllowtoDelete { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
