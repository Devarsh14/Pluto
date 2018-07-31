using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktProductShoppingCartWishList
    {
        public int ProductCrmid { get; set; }
        public long MaterialId { get; set; }
        public long CrmItemId { get; set; }
        public bool IsShoppingCartItem { get; set; }
        public bool IsWishListItem { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public int AlertMode { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int SetId { get; set; }
    }
}
