using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Address
    {
        public Address()
        {
            Affiliate = new HashSet<Affiliate>();
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomerBillingAddress = new HashSet<Customer>();
            CustomerShippingAddress = new HashSet<Customer>();
            OrderBillingAddress = new HashSet<Order>();
            OrderPickupAddress = new HashSet<Order>();
            OrderShippingAddress = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CustomAttributes { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Country Country { get; set; }
        public StateProvince StateProvince { get; set; }
        public ICollection<Affiliate> Affiliate { get; set; }
        public ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public ICollection<Customer> CustomerBillingAddress { get; set; }
        public ICollection<Customer> CustomerShippingAddress { get; set; }
        public ICollection<Order> OrderBillingAddress { get; set; }
        public ICollection<Order> OrderPickupAddress { get; set; }
        public ICollection<Order> OrderShippingAddress { get; set; }
    }
}
