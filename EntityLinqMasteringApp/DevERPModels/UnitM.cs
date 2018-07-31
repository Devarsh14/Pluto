using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class UnitM
    {
        public short UnitId { get; set; }
        public string UnitName { get; set; }
        public short UnitCategoryId { get; set; }
        public byte PrecisionDigits { get; set; }
        public bool IsDefaultUnit { get; set; }
        public bool IsBaseUnit { get; set; }
        public short UnitOrder { get; set; }
        public double ConversionFactor { get; set; }
        public short? BasisUnitId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
