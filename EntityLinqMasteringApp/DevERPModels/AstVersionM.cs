using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstVersionM
    {
        public int VersionId { get; set; }
        public string VersionName { get; set; }
        public int MachineId { get; set; }
        public double Cost { get; set; }
        public double PartCost { get; set; }
        public double LabourCost { get; set; }
        public double NoOfHours { get; set; }
        public int? EmpolyeeId { get; set; }
        public int? SupplierId { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
