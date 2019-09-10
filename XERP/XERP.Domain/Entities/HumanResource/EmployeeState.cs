using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.Common;
using XERP.Domain.Enumerations;

namespace XERP.Domain.Entities.HumanResource
{
    public class EmployeeState
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string SiteId { get; set; }
        public string EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int CostCenterId { get; set; }
        public int PositionId { get; set; }
        public int EmploymentTypeId { get; set; }
        public int EmployeeRankId { get; set; }
        public int TeamId { get; set; }
        public ChangeStateType ChangeType { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }

        public Company Companies { get; set; }
        public Site Site { get; set; }
        public Employee Employee { get; set; }
        public Department Departments { get; set; }
        public CostCenter CostCenters { get; set; }
        public Position Positions { get; set; }
        public EmploymentType EmploymentTypes { get; set; }
        public EmployeeRank EmployeeRanks { get; set; }
        public Team Teams { get; set; }


    }
}
