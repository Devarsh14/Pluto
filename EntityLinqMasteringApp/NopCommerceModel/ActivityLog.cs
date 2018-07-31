using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ActivityLog
    {
        public int Id { get; set; }
        public int ActivityLogTypeId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string IpAddress { get; set; }

        public ActivityLogType ActivityLogType { get; set; }
        public Customer Customer { get; set; }
    }
}
