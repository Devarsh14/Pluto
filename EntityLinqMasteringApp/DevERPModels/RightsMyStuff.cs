using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsMyStuff
    {
        public long MyStuffRightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public string DefaultPage { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool FullAccess { get; set; }
    }
}
