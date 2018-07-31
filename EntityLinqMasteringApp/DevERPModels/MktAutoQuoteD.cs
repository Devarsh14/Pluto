using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktAutoQuoteD
    {
        public int AutoQuoteDetId { get; set; }
        public int Rfqid { get; set; }
        public int MaterialFieldId { get; set; }
        public string FieldValue { get; set; }
        public int? FieldValueId { get; set; }
        public double? Gain { get; set; }
        public double? Offset { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
