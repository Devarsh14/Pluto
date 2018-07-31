using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccLedgers
    {
        public int LedgerId { get; set; }
        public string LedgerName { get; set; }
        public string LedgerAlias { get; set; }
        public string Description { get; set; }
        public short GroupId { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Enforcement { get; set; }
        public int? CompanyId { get; set; }
        public int? AssetId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ResponsibleEmployeeId { get; set; }
        public short? TaxId { get; set; }
        public int? MaterialSubCategoryId { get; set; }
        public int? ServiceId { get; set; }
        public bool? ErpOnly { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public bool? IsApproved { get; set; }
        public short? ApprovedUserId { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public int? CashBankId { get; set; }
        public bool? ApplyLimits { get; set; }
        public int? MergedIntoLedgerId { get; set; }
        public bool ApplyProjects { get; set; }
        public int ProjectId { get; set; }
    }
}
