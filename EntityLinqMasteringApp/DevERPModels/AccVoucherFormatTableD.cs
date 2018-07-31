using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVoucherFormatTableD
    {
        public long FormatTableDetId { get; set; }
        public long FormatTableId { get; set; }
        public int FormatId { get; set; }
        public int VoucherTypeId { get; set; }
        public byte TableNumber { get; set; }
        public int GroupId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
