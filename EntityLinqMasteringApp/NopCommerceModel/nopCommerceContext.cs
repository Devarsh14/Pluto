using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class nopCommerceContext : DbContext
    {
        public virtual DbSet<AclRecord> AclRecord { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttribute { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValue { get; set; }
        public virtual DbSet<Affiliate> Affiliate { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscription { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplate { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttribute { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValue { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProduct { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttribute { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValue { get; set; }
        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMapping { get; set; }
        public virtual DbSet<CustomerRole> CustomerRole { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDate { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; }
        public virtual DbSet<DiscountAppliedToManufacturers> DiscountAppliedToManufacturers { get; set; }
        public virtual DbSet<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirement { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistory { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<EmailAccount> EmailAccount { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public virtual DbSet<ForumsForum> ForumsForum { get; set; }
        public virtual DbSet<ForumsGroup> ForumsGroup { get; set; }
        public virtual DbSet<ForumsPost> ForumsPost { get; set; }
        public virtual DbSet<ForumsPostVote> ForumsPostVote { get; set; }
        public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessage { get; set; }
        public virtual DbSet<ForumsSubscription> ForumsSubscription { get; set; }
        public virtual DbSet<ForumsTopic> ForumsTopic { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttribute { get; set; }
        public virtual DbSet<GiftCard> GiftCard { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistory { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperty { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplate { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimension { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeight { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplate { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscription { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderNote> OrderNote { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecord { get; set; }
        public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMapping { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Poll> Poll { get; set; }
        public virtual DbSet<PollAnswer> PollAnswer { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecord { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValue { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttribute { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombination { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValue { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMapping { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMapping { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMapping { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMapping { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMapping { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulness { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMapping { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplate { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventory { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmail { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayment { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistory { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProduct { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequest { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestAction { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReason { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistory { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTask { get; set; }
        public virtual DbSet<SearchTerm> SearchTerm { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItem { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<ShippingMethodRestrictions> ShippingMethodRestrictions { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttribute { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOption { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreMapping> StoreMapping { get; set; }
        public virtual DbSet<TaxCategory> TaxCategory { get; set; }
        public virtual DbSet<TierPrice> TierPrice { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplate { get; set; }
        public virtual DbSet<UrlRecord> UrlRecord { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorNote> VendorNote { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=Shivangini;Initial Catalog= nopCommerce;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AclRecord>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.EntityName });

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.AclRecord)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("AclRecord_CustomerRole");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedOnUtc);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .HasConstraintName("ActivityLog_ActivityLogType");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("ActivityLog_Customer");
            });

            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("Address_Country");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("Address_StateProvince");
            });

            modelBuilder.Entity<AddressAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<AddressAttributeValue>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.AddressAttribute)
                    .WithMany(p => p.AddressAttributeValue)
                    .HasForeignKey(d => d.AddressAttributeId)
                    .HasConstraintName("AddressAttributeValue_AddressAttribute");
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Affiliate)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Affiliate_Address");
            });

            modelBuilder.Entity<BackInStockSubscription>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BackInStockSubscription)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("BackInStockSubscription_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BackInStockSubscription)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("BackInStockSubscription_Product");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.HasIndex(e => e.BlogPostId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("BlogComment_BlogPost");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("BlogComment_Customer");
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.HasIndex(e => e.LanguageId);

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.BlogPost)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("BlogPost_Language");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DontSendBeforeDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.HasIndex(e => e.LimitedToStores);

                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasIndex(e => e.SubjectToAcl);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<CategoryTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttributeValue>(entity =>
            {
                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CheckoutAttribute)
                    .WithMany(p => p.CheckoutAttributeValue)
                    .HasForeignKey(d => d.CheckoutAttributeId)
                    .HasConstraintName("CheckoutAttributeValue_CheckoutAttribute");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.CustomerGuid);

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => e.SystemName);

                entity.HasIndex(e => e.Username);

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.LastActivityDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username).HasMaxLength(1000);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomerBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("Customer_BillingAddress");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomerShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("Customer_ShippingAddress");
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId });

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("Customer_Addresses_Target");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Customer_Addresses_Source");
            });

            modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CustomerAttributeValue>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerAttributeValue)
                    .HasForeignKey(d => d.CustomerAttributeId)
                    .HasConstraintName("CustomerAttributeValue_CustomerAttribute");
            });

            modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId });

                entity.ToTable("Customer_CustomerRole_Mapping");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMapping)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Customer_CustomerRoles_Source");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMapping)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("Customer_CustomerRoles_Target");
            });

            modelBuilder.Entity<CustomerRole>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<DeliveryDate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<DiscountAppliedToCategories>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CategoryId });

                entity.ToTable("Discount_AppliedToCategories");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("Discount_AppliedToCategories_Target");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("Discount_AppliedToCategories_Source");
            });

            modelBuilder.Entity<DiscountAppliedToManufacturers>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ManufacturerId });

                entity.ToTable("Discount_AppliedToManufacturers");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("Discount_AppliedToManufacturers_Source");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("Discount_AppliedToManufacturers_Target");
            });

            modelBuilder.Entity<DiscountAppliedToProducts>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ProductId });

                entity.ToTable("Discount_AppliedToProducts");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("Discount_AppliedToProducts_Source");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("Discount_AppliedToProducts_Target");
            });

            modelBuilder.Entity<DiscountRequirement>(entity =>
            {
                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountRequirement)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("Discount_DiscountRequirements");
            });

            modelBuilder.Entity<DiscountUsageHistory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountUsageHistory)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("DiscountUsageHistory_Discount");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscountUsageHistory)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("DiscountUsageHistory_Order");
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalAuthenticationRecord)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("ExternalAuthenticationRecord_Customer");
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.ToTable("Forums_Forum");

                entity.HasIndex(e => e.DisplayOrder);

                entity.HasIndex(e => e.ForumGroupId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.LastPostTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumGroupId)
                    .HasConstraintName("Forum_ForumGroup");
            });

            modelBuilder.Entity<ForumsGroup>(entity =>
            {
                entity.ToTable("Forums_Group");

                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ForumsPost>(entity =>
            {
                entity.ToTable("Forums_Post");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.TopicId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsPost)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ForumPost_Customer");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ForumsPost)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("ForumPost_ForumTopic");
            });

            modelBuilder.Entity<ForumsPostVote>(entity =>
            {
                entity.ToTable("Forums_PostVote");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumsPostVote)
                    .HasForeignKey(d => d.ForumPostId)
                    .HasConstraintName("ForumPostVote_ForumPost");
            });

            modelBuilder.Entity<ForumsPrivateMessage>(entity =>
            {
                entity.ToTable("Forums_PrivateMessage");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.FromCustomer)
                    .WithMany(p => p.ForumsPrivateMessageFromCustomer)
                    .HasForeignKey(d => d.FromCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PrivateMessage_FromCustomer");

                entity.HasOne(d => d.ToCustomer)
                    .WithMany(p => p.ForumsPrivateMessageToCustomer)
                    .HasForeignKey(d => d.ToCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PrivateMessage_ToCustomer");
            });

            modelBuilder.Entity<ForumsSubscription>(entity =>
            {
                entity.ToTable("Forums_Subscription");

                entity.HasIndex(e => e.ForumId);

                entity.HasIndex(e => e.TopicId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsSubscription)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ForumSubscription_Customer");
            });

            modelBuilder.Entity<ForumsTopic>(entity =>
            {
                entity.ToTable("Forums_Topic");

                entity.HasIndex(e => e.ForumId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.LastPostTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsTopic)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ForumTopic_Customer");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsTopic)
                    .HasForeignKey(d => d.ForumId)
                    .HasConstraintName("ForumTopic_Forum");
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.KeyGroup })
                    .HasName("IX_GenericAttribute_EntityId_and_KeyGroup");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.PurchasedWithOrderItem)
                    .WithMany(p => p.GiftCard)
                    .HasForeignKey(d => d.PurchasedWithOrderItemId)
                    .HasConstraintName("GiftCard_PurchasedWithOrderItem");
            });

            modelBuilder.Entity<GiftCardUsageHistory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsageHistory)
                    .HasForeignKey(d => d.GiftCardId)
                    .HasConstraintName("GiftCardUsageHistory_GiftCard");

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.GiftCardUsageHistory)
                    .HasForeignKey(d => d.UsedWithOrderId)
                    .HasConstraintName("GiftCardUsageHistory_UsedWithOrder");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.HasIndex(e => new { e.ResourceName, e.LanguageId })
                    .HasName("IX_LocaleStringResource");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResource)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("LocaleStringResource_Language");
            });

            modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperty)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("LocalizedProperty_Language");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => e.CreatedOnUtc);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.ShortMessage).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Log_Customer");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.HasIndex(e => e.LimitedToStores);

                entity.HasIndex(e => e.SubjectToAcl);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ManufacturerTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<MeasureDimension>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MeasureWeight>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => e.LanguageId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Full).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Short).IsRequired();

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("NewsItem_Language");
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.HasIndex(e => e.NewsItemId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("NewsComment_Customer");

                entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.NewsItemId)
                    .HasConstraintName("NewsComment_NewsItem");
            });

            modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                entity.HasIndex(e => new { e.Email, e.StoreId })
                    .HasName("IX_NewsletterSubscription_Email_StoreId");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Order_BillingAddress");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Order_Customer");

                entity.HasOne(d => d.PickupAddress)
                    .WithMany(p => p.OrderPickupAddress)
                    .HasForeignKey(d => d.PickupAddressId)
                    .HasConstraintName("Order_PickupAddress");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("Order_ShippingAddress");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RentalEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.RentalStartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("OrderItem_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("OrderItem_Product");
            });

            modelBuilder.Entity<OrderNote>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNote)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("OrderNote_Order");
            });

            modelBuilder.Entity<PermissionRecord>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId });

                entity.ToTable("PermissionRecord_Role_Mapping");

                entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMapping)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("PermissionRecord_CustomerRoles_Target");

                entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMapping)
                    .HasForeignKey(d => d.PermissionRecordId)
                    .HasConstraintName("PermissionRecord_CustomerRoles_Source");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Poll)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Poll_Language");
            });

            modelBuilder.Entity<PollAnswer>(entity =>
            {
                entity.HasIndex(e => e.PollId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollAnswer)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("PollAnswer_Poll");
            });

            modelBuilder.Entity<PollVotingRecord>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PollVotingRecord)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("PollVotingRecord_Customer");

                entity.HasOne(d => d.PollAnswer)
                    .WithMany(p => p.PollVotingRecord)
                    .HasForeignKey(d => d.PollAnswerId)
                    .HasConstraintName("PollVotingRecord_PollAnswer");
            });

            modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.PredefinedProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("PredefinedProductAttributeValue_ProductAttribute");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.LimitedToStores);

                entity.HasIndex(e => e.ParentGroupedProductId);

                entity.HasIndex(e => e.Published);

                entity.HasIndex(e => e.ShowOnHomePage)
                    .HasName("IX_Product_ShowOnHomepage");

                entity.HasIndex(e => e.SubjectToAcl);

                entity.HasIndex(e => e.VisibleIndividually);

                entity.HasIndex(e => new { e.Published, e.Deleted })
                    .HasName("IX_Product_Deleted_and_Published");

                entity.HasIndex(e => new { e.Price, e.AvailableStartDateTimeUtc, e.AvailableEndDateTimeUtc, e.Published, e.Deleted })
                    .HasName("IX_Product_PriceDatesEtc");

                entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.AvailableEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.AvailableStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MarkAsNewEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.MarkAsNewStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PreOrderAvailabilityStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductAttributeCombination>(entity =>
            {
                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeCombination)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductAttributeCombination_Product");
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.HasIndex(e => new { e.ProductAttributeMappingId, e.DisplayOrder });

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttributeMapping)
                    .WithMany(p => p.ProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeMappingId)
                    .HasConstraintName("ProductAttributeValue_ProductAttributeMapping");
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                entity.ToTable("Product_Category_Mapping");

                entity.HasIndex(e => new { e.CategoryId, e.ProductId })
                    .HasName("IX_PCM_Product_and_Category");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("ProductCategory_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductCategory_Product");
            });

            modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                entity.ToTable("Product_Manufacturer_Mapping");

                entity.HasIndex(e => new { e.ManufacturerId, e.ProductId })
                    .HasName("IX_PMM_Product_and_Manufacturer");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMapping)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("ProductManufacturer_Manufacturer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductManufacturer_Product");
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMapping)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("ProductPicture_Picture");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductPicture_Product");
            });

            modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                entity.ToTable("Product_ProductAttribute_Mapping");

                entity.HasIndex(e => new { e.ProductId, e.DisplayOrder });

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMapping)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("ProductAttributeMapping_ProductAttribute");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductAttributeMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductAttributeMapping_Product");
            });

            modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductTagId });

                entity.ToTable("Product_ProductTag_Mapping");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("Product_ProductTags_Source");

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMapping)
                    .HasForeignKey(d => d.ProductTagId)
                    .HasConstraintName("Product_ProductTags_Target");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("ProductReview_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductReview_Product");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("ProductReview_Store");
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulness)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("ProductReviewHelpfulness_ProductReview");
            });

            modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                entity.ToTable("Product_SpecificationAttribute_Mapping");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_PSAM_ProductId");

                entity.HasIndex(e => new { e.ProductId, e.SpecificationAttributeOptionId, e.AllowFiltering })
                    .HasName("IX_PSAM_SpecificationAttributeOptionId_AllowFiltering");

                entity.Property(e => e.CustomValue).HasMaxLength(4000);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductSpecificationAttribute_Product");

                entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMapping)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId)
                    .HasConstraintName("ProductSpecificationAttribute_SpecificationAttributeOption");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductWarehouseInventory>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductWarehouseInventory)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductWarehouseInventory_Product");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouseInventory)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("ProductWarehouseInventory_Warehouse");
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.HasIndex(e => e.CreatedOnUtc);

                entity.Property(e => e.Bcc).HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DontSendBeforeDateUtc).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FromName).HasMaxLength(500);

                entity.Property(e => e.ReplyTo).HasMaxLength(500);

                entity.Property(e => e.ReplyToName).HasMaxLength(500);

                entity.Property(e => e.SentOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(1000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ToName).HasMaxLength(500);

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmail)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("QueuedEmail_EmailAccount");
            });

            modelBuilder.Entity<RecurringPayment>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.InitialOrder)
                    .WithMany(p => p.RecurringPayment)
                    .HasForeignKey(d => d.InitialOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RecurringPayment_InitialOrder");
            });

            modelBuilder.Entity<RecurringPaymentHistory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.RecurringPaymentHistory)
                    .HasForeignKey(d => d.RecurringPaymentId)
                    .HasConstraintName("RecurringPaymentHistory_RecurringPayment");
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.HasIndex(e => e.ProductId1);
            });

            modelBuilder.Entity<ReturnRequest>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ReasonForReturn).IsRequired();

                entity.Property(e => e.RequestedAction).IsRequired();

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReturnRequest)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("ReturnRequest_Customer");
            });

            modelBuilder.Entity<ReturnRequestAction>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReturnRequestReason>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<RewardPointsHistory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UsedWithOrderId).HasColumnName("UsedWithOrder_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RewardPointsHistory)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("RewardPointsHistory_Customer");

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.RewardPointsHistory)
                    .HasForeignKey(d => d.UsedWithOrderId)
                    .HasConstraintName("RewardPointsHistory_UsedWithOrder");
            });

            modelBuilder.Entity<ScheduleTask>(entity =>
            {
                entity.Property(e => e.LastEndUtc).HasColumnType("datetime");

                entity.Property(e => e.LastStartUtc).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessUtc).HasColumnType("datetime");

                entity.Property(e => e.LeasedUntilUtc).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ShippedDateUtc).HasColumnType("datetime");

                entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("Shipment_Order");
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItem)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("ShipmentItem_Shipment");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethodRestrictions>(entity =>
            {
                entity.HasKey(e => new { e.ShippingMethodId, e.CountryId });

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("ShippingMethod_RestrictedCountries_Target");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("ShippingMethod_RestrictedCountries_Source");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId });

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RentalEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.RentalStartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("ShoppingCartItem_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ShoppingCartItem_Product");
            });

            modelBuilder.Entity<SpecificationAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SpecificationAttributeOption>(entity =>
            {
                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOption)
                    .HasForeignKey(d => d.SpecificationAttributeId)
                    .HasConstraintName("SpecificationAttributeOption_SpecificationAttribute");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.HasIndex(e => new { e.DisplayOrder, e.CountryId })
                    .HasName("IX_StateProvince_CountryId");

                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("StateProvince_Country");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.CompanyVat).HasMaxLength(1000);

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.SecureUrl).HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<StoreMapping>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.EntityName });

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreMapping)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("StoreMapping_Store");
            });

            modelBuilder.Entity<TaxCategory>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TierPrice>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.TierPrice)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("TierPrice_CustomerRole");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TierPrice)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("TierPrice_Product");
            });

            modelBuilder.Entity<TopicTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.HasIndex(e => e.Slug);

                entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive })
                    .HasName("IX_UrlRecord_Custom_1");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            });

            modelBuilder.Entity<VendorNote>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorNote)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("VendorNote_Vendor");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });
        }
    }
}
