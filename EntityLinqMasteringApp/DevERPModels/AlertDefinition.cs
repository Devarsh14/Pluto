using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AlertDefinition
    {
        public short AlertDefinitionId { get; set; }
        public string AlertDefinition1 { get; set; }
        public string AlertClassification { get; set; }
        public long? Id { get; set; }
        public short RepeatOnHours { get; set; }
        public DateTime? SendTime { get; set; }
        public string AlertTypeId { get; set; }
        public DateTime? NextSendDt { get; set; }
        public DateTime CreateDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
