using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class UserM
    {
        public short UserId { get; set; }
        public short EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public short SupplierId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public short? PinNum { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public bool? IsAdministrator { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] Fingerprint { get; set; }
        public DateTime? LastMailCheckDt { get; set; }
        public bool IsCrmuser { get; set; }
        public string EmailId { get; set; }
        public DateTime? ChangePwdDate { get; set; }
    }
}
