using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.SYSTEM
{
    public class ClientCompanies
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public Guid ClientId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CompanyName { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string CompanyAddress { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ContactPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Designation { get; set; }
        public string IndustryType { get; set; }
        public string Description { get; set; }
        [Required]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }


        //Clients
        [ForeignKey("ClientId")]
        public virtual Clients Clients { get; set; }


    }
}
