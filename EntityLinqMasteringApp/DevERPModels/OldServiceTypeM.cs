using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldServiceTypeM
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public int? GroupId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
