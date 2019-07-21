using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class Positions {
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Code { get; set; }
    [Required]
    public string CompanyId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
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