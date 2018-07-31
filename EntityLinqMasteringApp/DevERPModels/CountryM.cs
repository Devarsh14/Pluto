using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class CountryM
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsOriginCountry { get; set; }
        public int CurrencyId { get; set; }
        public string DialingCode { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
