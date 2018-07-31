using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineTypeFieldsD
    {
        public int FieldId { get; set; }
        public short IndisciplineTypeId { get; set; }
        public string FieldName { get; set; }
        public short CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
