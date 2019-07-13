using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class Departments
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Code varchar { get; set; }
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
    public string LastModifiedById { get; set; }
    public DateTime LastModifiedAt { get; set; }
    [Required]
    public string VersionNo { get; set; }
    [Required]
    public string Status { get; set; }
}
}