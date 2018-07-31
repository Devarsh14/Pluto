using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdParameterM
    {
        public short ParameterId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDisplayName { get; set; }
        public short ParameterTypeId { get; set; }
        public short ParameterOrder { get; set; }
        public string ParameterDescription { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
