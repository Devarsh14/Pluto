using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmBreakD
    {
        public long BreakId { get; set; }
        public long AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public byte BreakTypeId { get; set; }
        public DateTime BreakOutDt { get; set; }
        public DateTime? BreakInDt { get; set; }
        public string BreakReason { get; set; }
        public bool? IsManualEntry { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
