using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVoucherTypesOptionNames
    {
        public short OptionId { get; set; }
        public short VoucherTypeId { get; set; }
        public string OptionNameToDisplay { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
