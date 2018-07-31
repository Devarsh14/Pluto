using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ForumsPrivateMessage
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int FromCustomerId { get; set; }
        public int ToCustomerId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeletedByAuthor { get; set; }
        public bool IsDeletedByRecipient { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Customer FromCustomer { get; set; }
        public Customer ToCustomer { get; set; }
    }
}
