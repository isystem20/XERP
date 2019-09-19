using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.Common;

namespace XERP.Domain.Entities.HumanResource
{
    public class Department
    {
        public Department()
        {
            EmployeeStates = new HashSet<EmployeeState>();
        }
        public string Id { get; set; }
        public string Code { get; set; }
        public string CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }
        public Company Companies { get; set; }

        public ICollection<EmployeeState> EmployeeStates { get; set; }
    }
}
