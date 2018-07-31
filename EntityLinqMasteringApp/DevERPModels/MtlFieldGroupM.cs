using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlFieldGroupM
    {
        public int MaterialFieldGroupId { get; set; }
        public string MaterialFieldGroup { get; set; }
        public short MaterialFieldGroupOrder { get; set; }
        public bool IsDeletePossible { get; set; }
        public byte? FieldGroupOrder { get; set; }
        public bool? HasMultiValueFields { get; set; }
        public bool? IsMandatory { get; set; }
        public byte? TestCriteriaType { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
