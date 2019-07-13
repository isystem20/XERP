using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeCertifications {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string CertificateId { get; set; }
        [Required]
        public string CertificateCustomName { get; set; }
        [Required]
        public string IssuedInstitution { get; set; }
        [Required]
        public string IssuedDate { get; set; }
        [Required]
        public string ValidityExpiration { get; set; }
        [Required]
        public string Remarks { get; set; }
        [Required]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public string LastModifiedById { get; set; }
        [Required]
        public DateTime LastModifiedAt { get; set; }
        [Required]
        public string VersionNo { get; set; }
        [Required]
        public string Status { get; set; }  
    }

}