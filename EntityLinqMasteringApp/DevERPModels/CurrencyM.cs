using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class CurrencyM
    {
        public byte CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string SecondCurrencyName { get; set; }
        public string CurrencyFullName { get; set; }
        public bool IsDefault { get; set; }
        public double LatestCurrencyPrice { get; set; }
        public byte CurrencyPrecisionDigits { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
