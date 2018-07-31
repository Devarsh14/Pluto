using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdFileTypeM
    {
        public short FileTypeId { get; set; }
        public string FileType { get; set; }
        public string FileExtension { get; set; }
        public DateTime CareatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte FileSizeInMb { get; set; }
    }
}
