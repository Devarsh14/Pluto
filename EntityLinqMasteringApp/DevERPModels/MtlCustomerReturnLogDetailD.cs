using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCustomerReturnLogDetailD
    {
        public long CustomerReturnDetailLogId { get; set; }
        public long CustomerReturnDetId { get; set; }
        public long InvoiceId { get; set; }
        public long BatchNoId { get; set; }
        public long MaterialId { get; set; }
        public int BrandId { get; set; }
        public string BatchNo { get; set; }
        public double? ReturnedQty { get; set; }
        public double? GoodsQty { get; set; }
        public double? ScrapQty { get; set; }
        public int? Status { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
