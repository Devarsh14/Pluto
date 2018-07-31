using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class CustomReports
    {
        public short CustomReportId { get; set; }
        public string PageTitle { get; set; }
        public string FileName { get; set; }
        public string ReportType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
