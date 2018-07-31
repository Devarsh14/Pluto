using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsAst
    {
        public int AstrightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPageTitle { get; set; }
        public bool AssetsInventory { get; set; }
        public bool ShowAssetWorth { get; set; }
        public bool EditAssetWorth { get; set; }
        public bool AssetEntry { get; set; }
        public bool ViewAssets { get; set; }
        public bool CreateAssets { get; set; }
        public bool UpdateAssets { get; set; }
        public bool DeleteAssets { get; set; }
        public bool AstMaintanance { get; set; }
        public bool ViewMaintananceSchedule { get; set; }
        public bool RegularMaintananceEntry { get; set; }
        public bool OverdueMaintananceEntry { get; set; }
        public bool AstRepairs { get; set; }
        public bool AstRepairEntry { get; set; }
        public bool AstRepairRequestApproval { get; set; }
        public bool AstMovement { get; set; }
        public bool ViewAstmovement { get; set; }
        public bool EnterAstmovement { get; set; }
        public bool AstReports { get; set; }
        public bool LocationConfiguration { get; set; }
        public bool RepairMaintananceConfiguration { get; set; }
        public bool AstConfiguration { get; set; }
        public bool AstOtherConfiguration { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
