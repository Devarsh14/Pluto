using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmQualificationD
    {
        public short QualificationDetId { get; set; }
        public short EmployeeTypeId { get; set; }
        public short QualificationId { get; set; }
        public int QualificationType { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
