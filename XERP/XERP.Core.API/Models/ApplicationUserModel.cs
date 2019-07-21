using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Core.API.Models
{
    public class ApplicationUserModel
    {
        [Required]
        public string UserCode { get; set; } //How to link it to a function generating uniquecode?

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string ClientId { get; set; }
        [Required]
        public string CompanyId { get; set; }

        public string EmployeeId { get; set; }
        [Required]
        public string SecurityHash { get; set; }

        public bool PasswordNeverExpires { get; set; }

        public bool UserCantChangePassword { get; set; }

        public bool UserChangePasswordNextLogon { get; set; }

        public DateTime PasswordDate { get; set; }

        public string ActivationCode { get; set; }

        public string Remarks { get; set; }

    }
}
