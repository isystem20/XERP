using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.SYSTEM
{
    public class UserModules
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Column (TypeName = "varchar(50)")]
        public string ClientId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CompanyId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ServiceId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ModuleId { get; set; }
        public string AccessHash { get; set; }
        [Required]
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }

    }
}
