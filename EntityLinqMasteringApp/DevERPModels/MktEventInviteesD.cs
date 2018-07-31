using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventInviteesD
    {
        public int InviteeId { get; set; }
        public int EventId { get; set; }
        public int InviteeTypeId { get; set; }
        public string InviteeType { get; set; }
        public int ReferenceId { get; set; }
        public int ContactId { get; set; }
        public string EmailId { get; set; }
        public string InviteeName { get; set; }
        public bool IsPresent { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
