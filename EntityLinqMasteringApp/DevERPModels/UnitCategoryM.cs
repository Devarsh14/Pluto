using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class UnitCategoryM
    {
        public short UnitCategoryId { get; set; }
        public string UnitCategory { get; set; }
        public short UnitCategoryOrder { get; set; }
        public bool IsLocked { get; set; }
        public bool IsTimeBasisUnit { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
