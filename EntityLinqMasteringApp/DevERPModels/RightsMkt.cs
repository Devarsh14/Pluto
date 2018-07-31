using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsMkt
    {
        public int MktrightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPageTitle { get; set; }
        public bool Customers { get; set; }
        public bool ViewCustomers { get; set; }
        public bool ViewCustomerPrint { get; set; }
        public bool CreateCustomer { get; set; }
        public bool UpdateCustomer { get; set; }
        public bool DeleteCustomer { get; set; }
        public bool MktInteractions { get; set; }
        public bool ViewInteractions { get; set; }
        public bool EnterInteractions { get; set; }
        public bool MktEvents { get; set; }
        public bool MktInquiryEntry { get; set; }
        public bool Quotation { get; set; }
        public bool PrepareQuotation { get; set; }
        public bool IssueQuotation { get; set; }
        public bool ReIssueQuotation { get; set; }
        public bool Poacceptance { get; set; }
        public bool EnterMktPo { get; set; }
        public bool ConfirmMktPo { get; set; }
        public bool RejectMktPo { get; set; }
        public bool MktDispatchEntry { get; set; }
        public bool MktInvoiceGeneration { get; set; }
        public bool MktFeedbackEntry { get; set; }
        public bool MktPaymentEntry { get; set; }
        public bool MktWebSiteSetup { get; set; }
        public bool MktConfiguration { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool MktReports { get; set; }
        public bool PartSpecificationEntry { get; set; }
        public bool CreatePartDraft { get; set; }
        public bool ApprovePartDraft { get; set; }
        public bool UpdatePart { get; set; }
        public bool DeletePart { get; set; }
        public bool ViewPartPrintable { get; set; }
    }
}
