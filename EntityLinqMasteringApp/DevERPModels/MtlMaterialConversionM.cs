using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlMaterialConversionM
    {
        public short MaterialConversionId { get; set; }
        public string MaterialConversionNum { get; set; }
        public string ConversionReason { get; set; }
        public string Notes { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
