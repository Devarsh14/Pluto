using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVoucherTypes
    {
        public short VoucherTypeId { get; set; }
        public string VoucherTypeName { get; set; }
        public string Description { get; set; }
        public bool AutoIncrement { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int? NextVoucherNum { get; set; }
        public bool AutoPrint { get; set; }
        public bool AskPassword { get; set; }
        public bool ShowIndividualNarration { get; set; }
        public bool ShowCommonNarration { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int FormatId { get; set; }
        public short VoucherClassificationId { get; set; }
    }
}
