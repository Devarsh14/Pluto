using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsFileTypes
    {
        public int FileTypeRightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int FileTypeId { get; set; }
        public bool NoAccess { get; set; }
        public bool ReadOnly { get; set; }
        public bool FullAccess { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
