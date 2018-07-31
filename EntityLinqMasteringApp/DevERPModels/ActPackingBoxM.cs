using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPackingBoxM
    {
        public int PackingBoxId { get; set; }
        public string BoxName { get; set; }
        public double BoxSizeLength { get; set; }
        public double BoxSizeWidth { get; set; }
        public double BoxSizeHeight { get; set; }
        public string BoxSizeUnit { get; set; }
        public double BoxWeight { get; set; }
        public string BoxWeightUnit { get; set; }
        public double GrossWeight { get; set; }
        public string NoofBoxes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
