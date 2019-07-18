using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class Employees
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string MiddleName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Suffix { get; set; }
        [Required]
        public DateTime BirthDate  { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string BirthPlace { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string CivilStatus { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public int NationalityId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string LastModifiedById { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public int VersionNo { get; set; } = 1;

        //public String Status { get; set; }
    }
}
