using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActInvoiceTermD
    {
        public long InvoiceTermDetId { get; set; }
        public long InvoiceId { get; set; }
        public short InvoiceTermId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
