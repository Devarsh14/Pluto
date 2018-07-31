using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Store
    {
        public Store()
        {
            ProductReview = new HashSet<ProductReview>();
            StoreMapping = new HashSet<StoreMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool SslEnabled { get; set; }
        public string SecureUrl { get; set; }
        public string Hosts { get; set; }
        public int DefaultLanguageId { get; set; }
        public int DisplayOrder { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyVat { get; set; }

        public ICollection<ProductReview> ProductReview { get; set; }
        public ICollection<StoreMapping> StoreMapping { get; set; }
    }
}
