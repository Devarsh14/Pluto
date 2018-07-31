using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldPrdWorkOrderEmployeeD
    {
        public long WorkOrderEmpDetId { get; set; }
        public long WorkOrderDetId { get; set; }
        public short EmployeeId { get; set; }
        public double Contribution { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
