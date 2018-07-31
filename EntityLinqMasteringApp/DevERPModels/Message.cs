using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string Message1 { get; set; }
        public string SendToNo { get; set; }
        public string Name { get; set; }
        public DateTime? SentDateTime { get; set; }
        public string MessageType { get; set; }
        public int? WorkOrderId { get; set; }
        public string CitizenId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? InvoiceId { get; set; }
        public bool? IsSent { get; set; }
        public bool IsError { get; set; }
        public string Error { get; set; }
        public int? MachineMaintenanceId { get; set; }
        public int? EmployeeId { get; set; }
        public int? MessageTypeId { get; set; }
        public int? MachineId { get; set; }
    }
}
