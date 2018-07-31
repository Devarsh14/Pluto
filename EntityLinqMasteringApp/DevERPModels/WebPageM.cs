using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class WebPageM
    {
        public short WebPageId { get; set; }
        public string WebPageName { get; set; }
        public string WebPageDisplayName { get; set; }
        public bool IsDefaultChecked { get; set; }
        public bool IsDefaultCheckedSupplier { get; set; }
        public bool IsCustomerPage { get; set; }
        public bool IsSupplierPage { get; set; }
        public short WebPageOrder { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsMandatorySupplier { get; set; }
        public bool IsDeleted { get; set; }
    }
}
