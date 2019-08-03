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
        public Guid? Id { get; set; }

        [Required]
        public string UserCode { get; set; } = "TEMP"; //How to link it to a function generating uniquecode?

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        //[Required]
        public Guid ClientId { get; set; } = new Guid();
        //[Required]
        public Guid CompanyId { get; set; } = new Guid();

        public Guid EmployeeId { get; set; }
        //[Required]
        public string SecurityHash { get; set; } = "TEMPHASH";

        public bool PasswordNeverExpires { get; set; }

        public bool UserCantChangePassword { get; set; }

        public bool UserChangePasswordNextLogon { get; set; }

        public DateTime PasswordDate { get; set; }

        public string ActivationCode { get; set; }

        public string Remarks { get; set; }

    }
}
