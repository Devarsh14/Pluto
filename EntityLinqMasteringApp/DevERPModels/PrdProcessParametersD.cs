﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessParametersD
    {
        public int ProcessParameterId { get; set; }
        public short ProcessStepId { get; set; }
        public short ParameterId { get; set; }
        public string IdealValue { get; set; }
        public string IdealMinValue { get; set; }
        public string IdealMaxValue { get; set; }
        public string ParameterValueUnitName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
