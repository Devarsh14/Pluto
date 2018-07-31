using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdMaterialFileLog
    {
        public int MaterialFileLogId { get; set; }
        public long MaterialId { get; set; }
        public int FileTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
