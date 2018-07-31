using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktGenieMailM
    {
        public int GenieMailId { get; set; }
        public int? SenderUserId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string SentUsing { get; set; }
        public DateTime? CreatedDt { get; set; }
        public bool? ShowToSender { get; set; }
        public bool IsPermDeleted { get; set; }
    }
}
