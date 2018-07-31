using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstBudgetPlanM
    {
        public int BudgetPlanId { get; set; }
        public int AssetCategoryId { get; set; }
        public int MachineTypeId { get; set; }
        public double Qty { get; set; }
        public double IndicativePrice { get; set; }
        public DateTime NeededBy { get; set; }
        public double ProquouredQty { get; set; }
        public double AmountBudget { get; set; }
        public double RemainingAmount { get; set; }
        public short DefaultCurrencyId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? RefId { get; set; }
        public int? CancelQty { get; set; }
    }
}
