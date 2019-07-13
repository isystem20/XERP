using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeEducationalHistory {
    [Required]
        public string Id { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string SchoolAddress { get; set; }
        [Required]
        public string Program { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public DateTime InclusiveDateFrom { get; set; }
        [Required]
        public DateTime InclusiveDateTo { get; set; }
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