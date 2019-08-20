using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Common
{
    public class CompanyRepresentative
    {
        public string Id { get; set; } 
        public string Code { get; set; }
        public string CompanyId { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }

        public Company Company { get; set; }
    }
}
