using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccRatioD
    {
        public int RatioDetId { get; set; }
        public int RatioId { get; set; }
        public int LedgerGroupId { get; set; }
        public bool IsLedger { get; set; }
        public bool IsNumerator { get; set; }
        public string NumeratorOperator { get; set; }
        public int NumeratorOrder { get; set; }
        public bool IsDenominator { get; set; }
        public string DenominatorOperator { get; set; }
        public int DenominatorOrder { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
