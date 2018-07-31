using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccGroups
    {
        public short GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupAlias { get; set; }
        public string PrefixForSubGroup { get; set; }
        public string PrefixForLedger { get; set; }
        public short GroupOrder { get; set; }
        public string AccType { get; set; }
        public string Description { get; set; }
        public short ParentGroupId { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Enforcement { get; set; }
        public short? AssetCategoryId { get; set; }
        public short? AssetTypeId { get; set; }
        public short? CompanyCategoryId { get; set; }
        public short? DepartmentId { get; set; }
        public short? MaterialCategoryId { get; set; }
        public string Position { get; set; }
        public bool IsLocked { get; set; }
        public bool? ErpOnly { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? ApplyLimit { get; set; }
        public bool? EnforceToPreventTransaction { get; set; }
        public bool? ApplyOnProRataBasisDuringYear { get; set; }
    }
}
