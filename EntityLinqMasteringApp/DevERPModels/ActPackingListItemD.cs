using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPackingListItemD
    {
        public long PackingListItemId { get; set; }
        public int PackingListId { get; set; }
        public int PackingBoxId { get; set; }
        public string BoxName { get; set; }
        public long InvoiceDetId { get; set; }
        public long ProductId { get; set; }
        public byte VersionNum { get; set; }
        public int PackedQty { get; set; }
        public bool IsPcbunit { get; set; }
        public double GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public string Pcbdesc { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
