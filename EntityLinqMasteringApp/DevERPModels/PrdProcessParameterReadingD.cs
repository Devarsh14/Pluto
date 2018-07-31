using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessParameterReadingD
    {
        public long ProcessParameterLogDetailId { get; set; }
        public long ProcessParameterLogId { get; set; }
        public int ProcessParameterId { get; set; }
        public short ProcessId { get; set; }
        public short ParameterId { get; set; }
        public string IdealValue { get; set; }
        public string IdealMinValue { get; set; }
        public string IdealMaxValue { get; set; }
        public string ParameterValueUnitName { get; set; }
        public string ActualValue { get; set; }
        public string Notes { get; set; }
        public byte Result { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
