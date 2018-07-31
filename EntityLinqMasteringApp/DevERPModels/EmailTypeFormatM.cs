using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class EmailTypeFormatM
    {
        public short EmailTypeFormatId { get; set; }
        public short EmailTypeId { get; set; }
        public string EmailTypeFormatNo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailHeader { get; set; }
        public string EmailBody1 { get; set; }
        public string EmailBody2 { get; set; }
        public string EmailBody3 { get; set; }
        public string EmailBody4 { get; set; }
        public string EmailFooter { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
