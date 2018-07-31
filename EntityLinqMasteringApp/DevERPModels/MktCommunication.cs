using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCommunication
    {
        public int CommunicationId { get; set; }
        public int CompanyId { get; set; }
        public string Mode { get; set; }
        public string InteractedWith { get; set; }
        public string Designation { get; set; }
        public string Topic { get; set; }
        public DateTime? Date { get; set; }
        public string Details { get; set; }
        public bool? Confidential { get; set; }
        public string InitiatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int CommunicationTypeId { get; set; }
    }
}
