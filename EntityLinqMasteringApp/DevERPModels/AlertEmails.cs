using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AlertEmails
    {
        public long EmailId { get; set; }
        public int AlertDefinitionId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public bool IsSent { get; set; }
        public bool? IsCanceled { get; set; }
        public bool? IsError { get; set; }
        public string Error { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? SendDt { get; set; }
        public DateTime? SentOn { get; set; }
    }
}
