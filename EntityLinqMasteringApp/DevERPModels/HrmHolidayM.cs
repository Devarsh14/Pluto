using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmHolidayM
    {
        public int HolidayId { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public bool? IsAllProductiondepartment { get; set; }
        public bool? IsNoProductiondepartment { get; set; }
        public bool? IsSelectedProductiondepartment { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCompanyWide { get; set; }
    }
}
