using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventResultsD
    {
        public int ResultId { get; set; }
        public int EventId { get; set; }
        public string Result { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string ResultName { get; set; }
        public int TypeId { get; set; }
    }
}
