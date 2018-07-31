using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmProjectM
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool ProjectStatus { get; set; }
        public int ProjectManagerEmpId { get; set; }
        public short AccessType { get; set; }
        public short IsPersonal { get; set; }
    }
}
