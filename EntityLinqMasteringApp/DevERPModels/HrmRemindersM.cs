using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmRemindersM
    {
        public long ReminderId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime ReminderDt { get; set; }
        public byte Status { get; set; }
        public bool GenieMailId { get; set; }
        public int ReminderForEmployeeId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int ReferenceTypeId { get; set; }
        public int ReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public double? Expectedcompletiontime { get; set; }
        public int? Duration { get; set; }
        public long? RoleId { get; set; }
        public long? CustomerId { get; set; }
        public DateTime? CompletedOn { get; set; }
        public bool ShowTaskTimeToReceiver { get; set; }
        public double? CompletionTime { get; set; }
        public int CompletionDuration { get; set; }
        public string Note { get; set; }
        public double CompletionPercentage { get; set; }
    }
}
