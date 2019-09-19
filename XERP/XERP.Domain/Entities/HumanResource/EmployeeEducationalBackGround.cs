using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.HumanResource
{
    public class EmployeeEducationalBackGround
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string Program { get; set; }
        public string Degree { get; set; }
        public DateTime InclusiveDateFrom { get; set; }
        public DateTime InclusiveDateTo { get; set; }
        public string Remarks { get; set; }
        public string CreatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }

    }
}
