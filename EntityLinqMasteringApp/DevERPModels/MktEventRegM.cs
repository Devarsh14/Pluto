using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventRegM
    {
        public long RegistrationId { get; set; }
        public int EventId { get; set; }
        public bool? IsApproved { get; set; }
        public string PersonName { get; set; }
        public string MobileNum { get; set; }
        public string EmailId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public double RegistrationCharges { get; set; }
    }
}
