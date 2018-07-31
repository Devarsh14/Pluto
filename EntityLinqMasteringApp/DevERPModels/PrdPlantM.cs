using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdPlantM
    {
        public short PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantAddress1 { get; set; }
        public string PlantAddress2 { get; set; }
        public string PlantCity { get; set; }
        public string PlantPinCode { get; set; }
        public string PlantState { get; set; }
        public string PlantCountry { get; set; }
        public string PlantContactInfo1 { get; set; }
        public string PlantContactInfo2 { get; set; }
        public string PlantContactInfo3 { get; set; }
        public string LocalInvoiceTemplateFileName { get; set; }
        public string ExportInvoiceTemplateFileName { get; set; }
        public string ExportInvoice2TemplateFileName { get; set; }
        public string ExportInvoice3TemplateFileName { get; set; }
        public string SezinvoiceTemplateFileName { get; set; }
        public string ScrapInvoiceTemplateFileName { get; set; }
        public string SalarySlipTemplateFileName { get; set; }
        public string ProjectPresenceRptTemplateFile { get; set; }
        public string TravelerCard1 { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
