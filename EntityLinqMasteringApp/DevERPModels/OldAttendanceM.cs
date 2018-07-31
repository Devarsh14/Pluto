using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAttendanceM
    {
        public int AttendanceId { get; set; }
        public int UserId { get; set; }
        public DateTime InDt { get; set; }
        public DateTime? OutDt { get; set; }
        public bool IsManual { get; set; }
    }
}
