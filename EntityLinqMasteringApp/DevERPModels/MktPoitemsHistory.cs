using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktPoitemsHistory
    {
        public long PoitemHistoryId { get; set; }
        public long PoitemId { get; set; }
        public int Poid { get; set; }
        public int ProductId { get; set; }
        public short VersionNum { get; set; }
        public long QuotationId { get; set; }
        public byte PotypeId { get; set; }
        public int? PoaunitId { get; set; }
        public int? SkunitId { get; set; }
        public double? QtyInPoaunitId { get; set; }
        public double? QtyInSkUnitId { get; set; }
        public double? CfSkunitIdToPoaunitIdNumerator { get; set; }
        public double? CfSkunitIdToPoaunitIdDenominator { get; set; }
        public short? PrecisionDigitsRate { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
        public string Charge1Name { get; set; }
        public double? Charge1Value { get; set; }
        public string Charge2Name { get; set; }
        public double? Charge2Value { get; set; }
        public string Charge3Name { get; set; }
        public double? Charge3Value { get; set; }
        public string Charge4Name { get; set; }
        public double? Charge4Value { get; set; }
        public DateTime? ExpShippingDt { get; set; }
        public DateTime DeliveryDt { get; set; }
        public DateTime? PaymentDueDt { get; set; }
        public int ShipperId { get; set; }
        public short DeliveryTypeId { get; set; }
        public bool? IsPending { get; set; }
        public bool? IsNew { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string ReasonForChange { get; set; }
        public bool IsDeleted { get; set; }
        public double Mrp { get; set; }
        public double Mrpamount { get; set; }
    }
}
