﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionL
    {
        public long TransactionLid { get; set; }
        public long MaterialTransactionId { get; set; }
        public int MaterialId { get; set; }
        public int? MaterialReceiveId { get; set; }
        public short CompletedTillProcessId { get; set; }
        public int LocationId { get; set; }
        public string BatchNo { get; set; }
        public int? BrandId { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double StockQty { get; set; }
        public double? ReceivedQty { get; set; }
        public double? RejectedQty { get; set; }
        public double? ScrapQty { get; set; }
        public double? ScrapQtySold { get; set; }
        public double? ReturnQty { get; set; }
        public double? InitialRate { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public bool? IsStore { get; set; }
        public int CompanyId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? PoitemId { get; set; }
        public int? CustomerId { get; set; }
    }
}
