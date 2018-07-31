using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsMtl
    {
        public int MtlrightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPageTitle { get; set; }
        public bool MtlStockStatusReport { get; set; }
        public bool MaterialIssue { get; set; }
        public bool MtlissueAgainstApprovedRequest { get; set; }
        public bool MtlissueRegardlessRequestOrApproval { get; set; }
        public bool MaterialAcceptance { get; set; }
        public bool AcceptReturnedMaterials { get; set; }
        public bool AcceptFinishedGoodsFromProduction { get; set; }
        public bool AcceptPurchasedMaterials { get; set; }
        public bool AcceptCustomerReturns { get; set; }
        public bool MtlacceptMakeExceptionInOrder { get; set; }
        public bool MtlpurchaseRequests { get; set; }
        public bool AutoApproveOwnPurchaseRequests { get; set; }
        public bool ApprovePurchaseRequests { get; set; }
        public bool MtlpurchaseOrders { get; set; }
        public bool PrepareMtlPo { get; set; }
        public bool ApproveMtlPo { get; set; }
        public bool UpdateMtlPo { get; set; }
        public bool CancelIssuedMtlPo { get; set; }
        public bool SupplierInteractions { get; set; }
        public bool SupplierLogInteractions { get; set; }
        public bool SupplierRequestQuote { get; set; }
        public bool SupplierReturnMaterials { get; set; }
        public bool SupplierSellScrap { get; set; }
        public bool SupplierManagement { get; set; }
        public bool ViewCompareSuppliers { get; set; }
        public bool CreateSupplier { get; set; }
        public bool UpdateSupplier { get; set; }
        public bool DeleteSupplier { get; set; }
        public bool MiscMtltransactions { get; set; }
        public bool ReconcileMtl { get; set; }
        public bool RevalueMtl { get; set; }
        public bool DisposeMtl { get; set; }
        public bool ConvertMtl { get; set; }
        public bool MtlReports { get; set; }
        public bool MtlEmailAlerts { get; set; }
        public bool PartSpecificationEntry { get; set; }
        public bool ViewPartPrintable { get; set; }
        public bool CreatePartDraft { get; set; }
        public bool ApprovePartDraft { get; set; }
        public bool UpdatePart { get; set; }
        public bool DeletePart { get; set; }
        public bool MtlConfiguration { get; set; }
        public bool Families { get; set; }
        public bool Categories { get; set; }
        public bool Characteristics { get; set; }
        public bool Brands { get; set; }
        public bool Units { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
