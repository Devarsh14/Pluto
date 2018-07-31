using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdFieldConfigurationCustomerProduct
    {
        public short PcbconfigurationFieldId { get; set; }
        public string PcbconfigurationFieldName { get; set; }
        public string PcbconfigurationFieldDisplayName { get; set; }
        public short PcbconfigurationFieldTypeId { get; set; }
        public short PcbconfigurationFieldOrder { get; set; }
        public bool IsUsedInPcb { get; set; }
        public bool IsUsedInPanel { get; set; }
        public bool IsUsedInSheet { get; set; }
        public bool IsUsedInWaste { get; set; }
        public short MaterialFieldId { get; set; }
        public string DefaultValue { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsFieldPcb1 { get; set; }
        public bool? IsFieldPanel1 { get; set; }
        public bool? IsFieldSheet1 { get; set; }
        public bool? IsFieldWaste1 { get; set; }
    }
}
