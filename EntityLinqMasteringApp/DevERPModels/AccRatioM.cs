using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccRatioM
    {
        public int RatioId { get; set; }
        public string RatioName { get; set; }
        public string RatioType { get; set; }
        public bool ShowInDashBoard { get; set; }
        public string HealthyType { get; set; }
        public double HealthyValue { get; set; }
        public string UnHealthyType { get; set; }
        public double UnHealthyValue { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
