using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmDepartmentM
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsProductionDept { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkAreaId { get; set; }
    }
}
