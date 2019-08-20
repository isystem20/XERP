using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.Common;
using XERP.Domain.Enumerations;

namespace XERP.Domain.Entities.HumanResource
{
    public class EmployeeDependent
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DependentRelation Relation { get; set; }
        public DateTime Birthdate { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }

        public Employee Employees { get; set; }
    }
}
