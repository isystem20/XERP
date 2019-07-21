using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.DataModel.SYSTEM;

namespace XERP.DataModel.HR
{
    public class Employees
    {
        public Guid Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        [Required]
        public string CivilStatus { get; set; }
        [Required]
        public int NationalityId { get; set; }
        [Required]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string LastModifiedById { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public int VersionNo { get; set; }

        public String Status { get; set; }


        //An Employee Can have multiple User Accounts.
        public virtual ICollection<ApplicationUsers> ApplicationUsers { get; set; }

    }
}
