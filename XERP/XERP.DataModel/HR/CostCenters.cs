using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class CostCenters {
    [Required]
    [Key]
    public string Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(50)")]
    public string Code { get; set; }

    [Required]
    [Column(TypeName = "varchar(50)")]
    public string CompanyId { get; set; } 

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "varchar(500)")]
    public string Description { get; set; }

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