using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstMachineWiseProcess
    {
        public int MachineWiseProcessStepId { get; set; }
        public int ProcessStepId { get; set; }
        public int? AssetCategoryId { get; set; }
        public int? MachineTypeId { get; set; }
        public int MachineId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsReqProcessReading { get; set; }
    }
}
