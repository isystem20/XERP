
using Microsoft.EntityFrameworkCore;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Entities.TimeKeeping;

namespace XERP.App.Interfaces
{
    public interface IAppDbContext
    {
        //Human Resources
        DbSet<Employee> Employees { get; set; }
        DbSet<Certificate> Certificates { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        DbSet<EmployeeDependent> EmployeeDependents { get; set; }
        DbSet<EmployeeRank> EmployeeRanks { get; set; }
        DbSet<EmployeeState> EmployeeStates { get; set; }
        DbSet<EmploymentType> EmploymentTypes { get; set; }
        DbSet<LeaveTypes> LeaveTypes { get; set; }
        DbSet<Nationality> Nationalities { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Team> Teams { get; set; }

        //TimeKeeping
    }
}
