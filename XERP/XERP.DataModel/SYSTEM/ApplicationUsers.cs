using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.DataModel.HR;

namespace XERP.DataModel.SYSTEM
{
    public class ApplicationUsers : IdentityUser
    {
        [Column(TypeName = "nvarchar(50)")]
        public string UserCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ClientId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CompanyId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string SecurityHash { get; set; }

        public bool PasswordNeverExpires { get; set; }

        public bool UserCantChangePassword { get; set; }

        public bool UserChangePasswordNextLogon { get; set; }

        public DateTime PasswordDate { get; set; }

        public string ActivationCode { get; set; }

        public string Remarks { get; set; }

        [Required]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string LastModifiedById { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public int VersionNo { get; set; }

        public String Status { get; set; }



        //User Accounts must have atleast 1 reference Employee
        [ForeignKey("EmployeeId")]
        public virtual Employees Employees { get; set; }

        //Client
        [ForeignKey("ClientId")]
        public virtual Clients Clients { get; set; }

        //Company
        [ForeignKey("CompanyId")]
        public virtual ClientCompanies ClientCompanies { get; set; }
    }
}
