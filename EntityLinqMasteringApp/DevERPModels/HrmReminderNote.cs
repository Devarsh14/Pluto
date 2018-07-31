using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmReminderNote
    {
        public long NoteId { get; set; }
        public DateTime NoteDt { get; set; }
        public long NoteEntryEmployeeId { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDt { get; set; }
        public long? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long ReminderId { get; set; }
    }
}
