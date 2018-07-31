using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActCashBankAccountM
    {
        public int CashBankAccountId { get; set; }
        public string CashBankAccountName { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public int? LedgerId { get; set; }
        public bool IsSynched { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
