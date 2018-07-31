using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessGroupM
    {
        public short ProcessGroupId { get; set; }
        public string ProcessGroupName { get; set; }
        public string ProcessGroupShortName { get; set; }
        public short? ProcessGroupOrder { get; set; }
        public double? MinWorkDone { get; set; }
        public double? MaxWorkDone { get; set; }
        public int? UnitId { get; set; }
        public string AlertSmsnumbersJobDelay { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
