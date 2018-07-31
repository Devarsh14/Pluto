﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktPiM
    {
        public int Piid { get; set; }
        public string Pino { get; set; }
        public int Poid { get; set; }
        public string BarcodeNo { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
