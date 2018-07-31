using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ConfigInvoiceTypeM
    {
        public short InvoiceTypeId { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public bool IsDefault { get; set; }
        public string Prefix { get; set; }
        public string CurrentInvoiceNo { get; set; }
        public string Suffix { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
