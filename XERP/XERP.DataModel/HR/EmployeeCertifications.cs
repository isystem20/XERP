using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeCertifications {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CompanyId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CertificateId { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CertificateCustomName { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string IssuedInstitution { get; set; }
        [Required]
        public string IssuedDate { get; set; }
        [Required]
        public string ValidityExpiration { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(50)")]
        public string LastModifiedById { get; set; }
        
        public DateTime LastModifiedAt { get; set; }

        public int VersionNo { get; set; } = 1;
        //[Required]
        //public string Status { get; set; }  
    }

}