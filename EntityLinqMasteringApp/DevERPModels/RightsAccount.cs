using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsAccount
    {
        public long AccrightsId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPage { get; set; }
        public bool CanCreateGroups { get; set; }
        public bool CanEnterVouchers { get; set; }
        public bool CanApproveVouchers { get; set; }
        public bool CanCreateLedgers { get; set; }
        public bool CanApproveLedgers { get; set; }
        public bool CanCreateVoucherTypes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string AccConfig { get; set; }
        public string Groups { get; set; }
        public string Ledgers { get; set; }
        public string Profitability { get; set; }
        public string Reconcilition { get; set; }
        public string Stock { get; set; }
        public string VoucherTypes { get; set; }
        public string VoucherEntry { get; set; }
        public string UserEntry { get; set; }
        public string CashFlowPlanning { get; set; }
        public string Indicators { get; set; }
        public string Reports { get; set; }
        public string Ratio { get; set; }
        public string VoucherFormat { get; set; }
    }
}
