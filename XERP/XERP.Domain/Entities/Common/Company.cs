using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Domain.Entities.Common
{
    public class Company
    {
        public Company()
        {
            CompanyRepresentative = new HashSet<CompanyRepresentative>();
            Sites = new HashSet<Site>();
            EmployeeState = new HashSet<EmployeeState>();
            Departments = new HashSet<Department>();
            CostCenters = new HashSet<CostCenter>();
            Positions = new HashSet<Position>();
            EmployeeCertificates = new HashSet<EmployeeCertificate>();

        }
        public string Id { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ContactPersons { get; set; }
        public string Designation { get; set; }
        public string IndustryId { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }

        public Industry Industries { get; set; }

        public ICollection<CompanyRepresentative> CompanyRepresentative { get; set; }
        public ICollection<Site> Sites { get; set; }
        public ICollection<EmployeeState> EmployeeState { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<CostCenter> CostCenters { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
        public ICollection<EmployeeDependent> EmployeeDependents { get; set; }
    }
}
