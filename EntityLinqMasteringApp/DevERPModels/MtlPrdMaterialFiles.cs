using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdMaterialFiles
    {
        public int MaterialFileTypeId { get; set; }
        public int MaterialId { get; set; }
        public int FileTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
