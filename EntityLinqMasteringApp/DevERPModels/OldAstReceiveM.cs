using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAstReceiveM
    {
        public int AssetReceiveId { get; set; }
        public int AssetPoid { get; set; }
        public double SubTotal { get; set; }
        public double AssessableValue { get; set; }
        public string OtherChargesaName { get; set; }
        public double OtherChargesValue { get; set; }
        public int ExciseTaxId { get; set; }
        public double ExciseStructAmt { get; set; }
        public double TotalAfterExciseDuty { get; set; }
        public double FreightBeforeTax { get; set; }
        public double TotalAfterFreightTax { get; set; }
        public int SaleTaxId { get; set; }
        public double SalesStructAmt { get; set; }
        public double TotalAfterSalesTax { get; set; }
        public double GrandTotal { get; set; }
        public double GrandTotalDefaultCurrency { get; set; }
        public bool IsPaid { get; set; }
        public string Remarks { get; set; }
        public DateTime ReceivedDt { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string DeliveryChallanNo { get; set; }
        public DateTime? InvoiceDt { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
