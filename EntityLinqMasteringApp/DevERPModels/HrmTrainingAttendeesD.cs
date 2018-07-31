using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmTrainingAttendeesD
    {
        public int AttendeeId { get; set; }
        public int TrainingId { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsPresent { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
