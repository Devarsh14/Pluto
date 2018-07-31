using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmShiftM
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public double WorkingHours { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
