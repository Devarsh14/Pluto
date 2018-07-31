using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AlertRecipient
    {
        public int RecipientId { get; set; }
        public int AlertDefinitionId { get; set; }
        public string RecipientName { get; set; }
        public string Recipient { get; set; }
        public DateTime CreateDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
