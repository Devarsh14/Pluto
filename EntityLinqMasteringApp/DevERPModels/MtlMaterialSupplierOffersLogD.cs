using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlMaterialSupplierOffersLogD
    {
        public long MaterialSupplierOffersLogDetId { get; set; }
        public long MaterialId { get; set; }
        public int SupplierId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsRfq { get; set; }
        public double Qty { get; set; }
        public short LeadTimeInDays { get; set; }
        public double Rate { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRefuse { get; set; }
        public DateTime? RefuseDt { get; set; }
        public long RefRfqMtlsupplierOfferLogDetId { get; set; }
        public string Notes { get; set; }
        public DateTime? RfqValidTillDt { get; set; }
        public DateTime? OfferValidTillDt { get; set; }
    }
}
