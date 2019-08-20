using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.Common;

namespace XERP.Domain.Entities.HumanResource
{
    public class EmployeeCertificate
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string CertificateId { get; set; }
        public string CertificateCustomName { get; set; }
        public string IssuedInstitution { get; set; }
        public string IssuedDate { get; set; }
        public string ValidityExpiration { get; set; }
        public string Remarks { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }

        public Company Companies { get; set; }
        public Employee Employees { get; set; }
        public Certificate Certificates { get; set; }
    }
}
