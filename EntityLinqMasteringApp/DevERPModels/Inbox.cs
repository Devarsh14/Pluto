using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class Inbox
    {
        public int MessageId { get; set; }
        public string PhoneNo { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime? ReadDt { get; set; }
        public bool IsRead { get; set; }
    }
}
