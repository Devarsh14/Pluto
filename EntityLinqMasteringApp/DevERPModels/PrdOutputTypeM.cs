using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdOutputTypeM
    {
        public short OutputTypeId { get; set; }
        public string OutputTypeName { get; set; }
        public string OutputTypeCode { get; set; }
        public string OutputErrorType { get; set; }
        public string OutputCategory { get; set; }
        public bool IsMandatory { get; set; }
        public byte ResponsibleProcessType { get; set; }
        public int ResponsibleProcessStepId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte? ProcessStepId { get; set; }
        public string OutputNum { get; set; }
        public string UnitOutputTypeName { get; set; }
        public bool IsCurrentProcessReponsible { get; set; }
    }
}
