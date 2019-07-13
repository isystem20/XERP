using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeStates
    {
        public int Id { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string SiteId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int CostCenterId { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public int EmployeeTypeId { get; set; }
        [Required]
        public int EmployeeRankId { get; set; }
        [Required]
        public string ChangeType { get; set; }
        [Required]
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Status { get; set; }

    }
}
