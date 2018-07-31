using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ConfigM
    {
        public int FieldId { get; set; }
        public string Field { get; set; }
        public string DisplayText { get; set; }
        public string Value { get; set; }
        public bool IsGeneral { get; set; }
        public bool ShowInAsset { get; set; }
        public bool ShowInMarketing { get; set; }
        public bool ShowInMaterial { get; set; }
        public bool ShowInProduction { get; set; }
        public bool ShowInMarketingSales { get; set; }
        public bool ShowInHr { get; set; }
        public bool ShowInPcbConfiguration { get; set; }
        public bool ShowInAccount { get; set; }
        public string DisplayForm { get; set; }
        public bool? DisplayToUsers { get; set; }
        public string Validation { get; set; }
        public double NumRangeFrom { get; set; }
        public double NumRangeTo { get; set; }
        public short TextLength { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
