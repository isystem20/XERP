using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeDependents {
        [Required]
        public string Id { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Relation { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
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