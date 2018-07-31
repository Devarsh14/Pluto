using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventM
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string Venue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int InchargeEmpId { get; set; }
        public string EventTypeId { get; set; }
        public string ResultTypeId { get; set; }
        public bool IsBasicInfoCompleted { get; set; }
        public bool IsCompletedSave { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Visibility { get; set; }
        public bool AllowRegistration { get; set; }
        public bool? IsAutoApprove { get; set; }
        public long NewsId { get; set; }
        public string EventImage { get; set; }
        public string Description { get; set; }
    }
}
