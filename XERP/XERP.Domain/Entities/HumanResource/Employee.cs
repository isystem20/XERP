using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.HumanResource
{
    public class Employee
    {
        public Employee()
        {
            UserAccounts = new HashSet<ApplicationUser>();
            EmployeeStates = new HashSet<EmployeeState>();
            EmployeeCertificates = new HashSet<EmployeeCertificate>();
        }

        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string CivilStatus { get; set; }
        public string NationalityId { get; set; }
        public string CreatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public String Status { get; set; }

        public Nationality Nationality { get; set; }

        public ICollection<ApplicationUser> UserAccounts { get; private set; }
        public ICollection<EmployeeState> EmployeeStates { get; private set; }
        public ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }

    }
}
