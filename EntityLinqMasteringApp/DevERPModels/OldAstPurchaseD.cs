using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAstPurchaseD
    {
        public int AssetPodetailId { get; set; }
        public int AssetPoid { get; set; }
        public int? AssetCategoryId { get; set; }
        public int MachineTypeId { get; set; }
        public double Qty { get; set; }
        public double Rate { get; set; }
        public decimal TotalAmt { get; set; }
        public double TotalAmtDefaultCurrency { get; set; }
        public int? SupplierId { get; set; }
        public short? CurrencyId { get; set; }
        public DateTime NeededBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string QuoteNum { get; set; }
        public int? BudgetPlanId { get; set; }
    }
}
