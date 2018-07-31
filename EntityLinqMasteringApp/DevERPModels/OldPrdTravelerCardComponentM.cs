using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldPrdTravelerCardComponentM
    {
        public int TravelerCardComponentId { get; set; }
        public string TravelerCardComponentName { get; set; }
        public int TravelerCardComponentValueCellX { get; set; }
        public string TravelerCardComponentValueCellY { get; set; }
        public bool IsVisibleTravelerCard { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string TravelerCardComponentDisplayName { get; set; }
        public int? TravelerCardComponentCellX { get; set; }
        public string TravelerCardComponentCellY { get; set; }
    }
}
