using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdHrmProcessSteps
    {
        public int EmployeeProcessStepId { get; set; }
        public short EmployeeId { get; set; }
        public byte ProcessStepId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
