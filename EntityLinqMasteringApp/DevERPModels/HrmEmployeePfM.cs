using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeePfM
    {
        public int EmployeePfid { get; set; }
        public int EmployeeId { get; set; }
        public string EpfmemberId { get; set; }
        public string MemberFname { get; set; }
        public string MemberMname { get; set; }
        public string MemberLname { get; set; }
        public string RelativeFname { get; set; }
        public string RelativeMname { get; set; }
        public string RelativeLname { get; set; }
        public string RelationshipWithMember { get; set; }
        public DateTime EpfJoinDt { get; set; }
        public DateTime EpsJoinDt { get; set; }
        public DateTime? EpfExitDt { get; set; }
        public DateTime? EpsExitDt { get; set; }
        public short? ReasonId { get; set; }
        public string LeaveReason { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? PfBirthDate { get; set; }
    }
}
