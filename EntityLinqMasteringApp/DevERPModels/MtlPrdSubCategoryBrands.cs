﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdSubCategoryBrands
    {
        public int MaterialSubCategoryBrandId { get; set; }
        public int BrandId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
