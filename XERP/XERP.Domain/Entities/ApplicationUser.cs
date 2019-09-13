using System;
using XERP.Domain.ValueObjects;

namespace XERP.Domain.Entities
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public AdAccount AdAccount { get; set; }
        public string UserCode { get; set; }
        public string ClientId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public bool PasswordNeverExpires { get; set; }
        public bool UserCantChangePassword { get; set; }
        public bool UserChangePasswordNextLogon { get; set; }
        public string ActivationCode { get; set; }
        public string SecurityStamp { get; set; }
        public string SecurityHash { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Remarks { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }



    }
}
