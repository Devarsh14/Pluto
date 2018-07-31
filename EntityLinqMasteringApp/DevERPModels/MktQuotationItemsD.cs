using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktQuotationItemsD
    {
        public int RfqdetId { get; set; }
        public int Rfqid { get; set; }
        public byte VersionNum { get; set; }
        public int GerberFileTypeId { get; set; }
        public string GerberFileName { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
