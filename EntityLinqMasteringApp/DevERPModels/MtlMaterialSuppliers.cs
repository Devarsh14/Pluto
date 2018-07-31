using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlMaterialSuppliers
    {
        public long MaterialSupplierId { get; set; }
        public long MaterialId { get; set; }
        public int SupplierId { get; set; }
        public double? RfqQty { get; set; }
        public int? RfqLeadTimeInDays { get; set; }
        public bool IsRefuse { get; set; }
        public double? MinQty { get; set; }
        public int? LeadTimeInDays { get; set; }
        public double? RateOffered { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double? RfqRate { get; set; }
        public DateTime? RfqDt { get; set; }
        public bool IsNewRfq { get; set; }
        public DateTime RateOfferedDt { get; set; }
        public long RfqMtlsupplierOfferLogDetId { get; set; }
        public DateTime? RfqValidTillDt { get; set; }
        public DateTime? OfferValidTillDt { get; set; }
        public DateTime? RefuseDt { get; set; }
        public bool DefaultSupplier { get; set; }
        public bool AllowDirectShipment { get; set; }
        public bool AllowSupplierToGenerateInvoice { get; set; }
    }
}
