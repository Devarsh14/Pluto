using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class EmailTypeRecipientM
    {
        public int EmailTypeRecipientId { get; set; }
        public short EmailTypeId { get; set; }
        public short DesignationId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmailId { get; set; }
        public string RecipientEmailIdname { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
