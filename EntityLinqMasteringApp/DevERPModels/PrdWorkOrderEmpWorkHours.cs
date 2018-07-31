using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderEmpWorkHours
    {
        public long WorkOrderEmpWorkHoursId { get; set; }
        public long WorkOrderId { get; set; }
        public long ProcessStepId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? WorkHours { get; set; }
        public double HourCost { get; set; }
        public double TotalCost { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool Isdeleted { get; set; }
    }
}
