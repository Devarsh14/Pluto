using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmConfInputTopics
    {
        public long TopicId { get; set; }
        public string TopicName { get; set; }
        public byte NatureTypeId { get; set; }
        public byte ActionNeeded { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
