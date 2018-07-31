using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAchievementAlertsSent
    {
        public long AchievementAlertsSentId { get; set; }
        public long AchievementId { get; set; }
        public int EmployeeId { get; set; }
        public long EmailId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
