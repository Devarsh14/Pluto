using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldPrdProductParameterM
    {
        public int ProductParameterId { get; set; }
        public int ProductId { get; set; }
        public byte VersionNum { get; set; }
        public int ParameterId { get; set; }
        public int ParameterOptionId { get; set; }
        public int ProductTypeId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
