using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Customer
    {
        public Customer()
        {
            ActivityLog = new HashSet<ActivityLog>();
            BackInStockSubscription = new HashSet<BackInStockSubscription>();
            BlogComment = new HashSet<BlogComment>();
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomerCustomerRoleMapping = new HashSet<CustomerCustomerRoleMapping>();
            ExternalAuthenticationRecord = new HashSet<ExternalAuthenticationRecord>();
            ForumsPost = new HashSet<ForumsPost>();
            ForumsPrivateMessageFromCustomer = new HashSet<ForumsPrivateMessage>();
            ForumsPrivateMessageToCustomer = new HashSet<ForumsPrivateMessage>();
            ForumsSubscription = new HashSet<ForumsSubscription>();
            ForumsTopic = new HashSet<ForumsTopic>();
            Log = new HashSet<Log>();
            NewsComment = new HashSet<NewsComment>();
            Order = new HashSet<Order>();
            PollVotingRecord = new HashSet<PollVotingRecord>();
            ProductReview = new HashSet<ProductReview>();
            ReturnRequest = new HashSet<ReturnRequest>();
            RewardPointsHistory = new HashSet<RewardPointsHistory>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
        }

        public int Id { get; set; }
        public Guid CustomerGuid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PasswordFormatId { get; set; }
        public string PasswordSalt { get; set; }
        public string AdminComment { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AffiliateId { get; set; }
        public int VendorId { get; set; }
        public bool HasShoppingCartItems { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime LastActivityDateUtc { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public ICollection<ActivityLog> ActivityLog { get; set; }
        public ICollection<BackInStockSubscription> BackInStockSubscription { get; set; }
        public ICollection<BlogComment> BlogComment { get; set; }
        public ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public ICollection<CustomerCustomerRoleMapping> CustomerCustomerRoleMapping { get; set; }
        public ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public ICollection<ForumsPost> ForumsPost { get; set; }
        public ICollection<ForumsPrivateMessage> ForumsPrivateMessageFromCustomer { get; set; }
        public ICollection<ForumsPrivateMessage> ForumsPrivateMessageToCustomer { get; set; }
        public ICollection<ForumsSubscription> ForumsSubscription { get; set; }
        public ICollection<ForumsTopic> ForumsTopic { get; set; }
        public ICollection<Log> Log { get; set; }
        public ICollection<NewsComment> NewsComment { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<PollVotingRecord> PollVotingRecord { get; set; }
        public ICollection<ProductReview> ProductReview { get; set; }
        public ICollection<ReturnRequest> ReturnRequest { get; set; }
        public ICollection<RewardPointsHistory> RewardPointsHistory { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
    }
}
