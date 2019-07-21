using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class PreviousEmployers {
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string RegisteredName { get; set; }
        public string TIN { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public string LastModifiedById { get; set; }
        [Required]
        public DateTime LastModifiedAt { get; set; }
        
    }

}