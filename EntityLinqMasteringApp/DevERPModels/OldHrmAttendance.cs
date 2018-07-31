using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAttendance
    {
        public short EmployeeAttendanceId { get; set; }
        public short DesignationId { get; set; }
        public DateTime AttendanceEntryDate { get; set; }
        public byte AttendanceStatus { get; set; }
        public short EmployeeId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public bool IsInOrOut { get; set; }
        public double Othours { get; set; }
        public double? Otminutes { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Otreason { get; set; }
    }
}
