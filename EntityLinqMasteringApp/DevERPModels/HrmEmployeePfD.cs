using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeePfD
    {
        public int EmployeePfdetId { get; set; }
        public int EmployeePfid { get; set; }
        public int EmployeeId { get; set; }
        public short PfMonth { get; set; }
        public short PfYear { get; set; }
        public bool IsPfgenerated { get; set; }
        public bool IsChecked { get; set; }
        public long? Epfwages { get; set; }
        public long? Epswages { get; set; }
        public long? EpfcontributionDueEe { get; set; }
        public long? EpfcontributionRemittedEe { get; set; }
        public long? EpscontributionDue { get; set; }
        public long? EpscontributionRemitted { get; set; }
        public long? DiffEpfEpsContributionDueEr { get; set; }
        public long? DiffEpfEpsContributionRemittedEr { get; set; }
        public short? Ncpdays { get; set; }
        public long? RefundAdvances { get; set; }
        public long? ArrearEpfwages { get; set; }
        public long? ArrearEpfEe { get; set; }
        public long? ArrearEpfEr { get; set; }
        public long? ArrearEps { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
