using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdFamilyConfigurationCustomerProduct
    {
        public short PcbconfigurationFamilyId { get; set; }
        public short MaterialSubCategoryId { get; set; }
        public bool IsUsedInPcb { get; set; }
        public bool IsUsedInPanel { get; set; }
        public bool IsUsedInSheet { get; set; }
        public bool IsUsedInWaste { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsFieldPcb1 { get; set; }
        public bool? IsFieldPanel1 { get; set; }
        public bool? IsFieldSheet1 { get; set; }
        public bool? IsFieldWaste1 { get; set; }
    }
}
