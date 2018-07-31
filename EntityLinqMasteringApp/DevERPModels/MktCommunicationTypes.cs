﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCommunicationTypes
    {
        public int CommunicationTypeId { get; set; }
        public string CommunicationType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? Confidential { get; set; }
    }
}
