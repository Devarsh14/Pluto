﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActDeliveryTypeM
    {
        public short DeliveryTypeId { get; set; }
        public string DeliveryTypeName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
