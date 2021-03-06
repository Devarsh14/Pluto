﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstAssetInchargeD
    {
        public int AssetInchargeId { get; set; }
        public int AssetId { get; set; }
        public int InchargeEmployeeId { get; set; }
        public bool IsMainIncharge { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
