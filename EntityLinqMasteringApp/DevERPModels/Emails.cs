using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class Emails
    {
        public int EmailId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailTo { get; set; }
        public string EmailType { get; set; }
        public string EmailFrom { get; set; }
        public bool IsSent { get; set; }
        public bool? IsError { get; set; }
        public string Error { get; set; }
        public DateTime? SentOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
