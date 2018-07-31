using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstAreaM
    {
        public int AreaId { get; set; }
        public int PlantId { get; set; }
        public string AreaName { get; set; }
        public string Description { get; set; }
        public bool IsStore { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
