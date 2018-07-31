using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmLeaveRequestD
    {
        public int LeaveRequestDetailId { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveRequestId { get; set; }
        public DateTime Date { get; set; }
        public bool IsFirstHalf { get; set; }
        public bool IsSecondHalf { get; set; }
        public bool IsFullDay { get; set; }
        public bool IsCancel { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
