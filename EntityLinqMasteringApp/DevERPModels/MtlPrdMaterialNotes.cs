using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdMaterialNotes
    {
        public long MaterialNoteId { get; set; }
        public long MaterialId { get; set; }
        public string TitleNote { get; set; }
        public string Note { get; set; }
        public byte NoteCategoryId { get; set; }
        public string NoteCategoryName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
