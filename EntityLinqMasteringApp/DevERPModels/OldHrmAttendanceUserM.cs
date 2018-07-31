using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAttendanceUserM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public byte[] Fingerprint { get; set; }
        public string InTime { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
