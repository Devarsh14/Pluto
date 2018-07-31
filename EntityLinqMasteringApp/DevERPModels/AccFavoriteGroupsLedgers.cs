using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccFavoriteGroupsLedgers
    {
        public long FavoriteId { get; set; }
        public int? FavoriteGroupId { get; set; }
        public int FavoriteLedgerId { get; set; }
        public short UserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
