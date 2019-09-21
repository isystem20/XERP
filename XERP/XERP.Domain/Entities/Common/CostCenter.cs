using System;
using System.Collections.Generic;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Domain.Entities.Common
{
    public class CostCenter
    {
        public CostCenter()
        {
            EmployeeStates = new HashSet<EmployeeState>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }

        public Company Companies { get; set; }
        public ICollection<EmployeeState> EmployeeStates { get; set; }
    }
}
