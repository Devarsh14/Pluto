using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class EmailTypeM
    {
        public short EmailTypeId { get; set; }
        public string EmailType { get; set; }
        public string Description { get; set; }
        public string AutoEmailFromName { get; set; }
        public bool IsAllowReply { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToEmailId { get; set; }
        public string ReplyToEmailIdname { get; set; }
        public bool IsAllowCc { get; set; }
        public string CctoName { get; set; }
        public string CctoEmailId { get; set; }
        public string CctoEmailIdname { get; set; }
        public bool IsAllowBcc { get; set; }
        public string BcctoName { get; set; }
        public string BcctoEmailId { get; set; }
        public string BcctoEmailIdname { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
