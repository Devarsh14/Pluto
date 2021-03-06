﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstFieldTypeAssetM
    {
        public int FieldTypeAssetId { get; set; }
        public int FieldTypeDetailId { get; set; }
        public int FieldTypeId { get; set; }
        public int MachineId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
