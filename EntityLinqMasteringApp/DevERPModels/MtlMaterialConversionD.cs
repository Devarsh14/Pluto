using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlMaterialConversionD
    {
        public short MaterialConversionDetId { get; set; }
        public short MaterialConversionId { get; set; }
        public short? FamilyId { get; set; }
        public short MaterialId { get; set; }
        public short? BrandId { get; set; }
        public string BatchNo { get; set; }
        public double InQty { get; set; }
        public double OutQty { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
