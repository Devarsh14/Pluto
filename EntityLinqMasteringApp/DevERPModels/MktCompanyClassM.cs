using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyClassM
    {
        public byte CompanyClassId { get; set; }
        public string CompanyClassName { get; set; }
        public short GroupId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
