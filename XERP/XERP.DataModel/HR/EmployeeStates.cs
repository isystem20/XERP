using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeeStates
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CompanyId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string SiteId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EmployeeId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public int DepartmentId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public int CostCenterId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public int PositionId { get; set; }
       
        [Column(TypeName = "varchar(50)")]
        public int EmployeeTypeId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public int EmployeeRankId { get; set; }
        [Required]
        public string ChangeType { get; set; }
        [Required]
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Status { get; set; }

    }
}
