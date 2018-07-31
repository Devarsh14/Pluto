using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventRegCharges
    {
        public long RegistrationChargesId { get; set; }
        public int EventId { get; set; }
        public DateTime FromDt { get; set; }
        public DateTime ToDt { get; set; }
        public double Amount { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
