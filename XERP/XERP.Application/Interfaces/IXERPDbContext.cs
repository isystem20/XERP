using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using XERP.Domain.Entities;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.CompanyResource;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Entities.Payroll;
using XERP.Domain.Entities.TimeKeeping;

namespace XERP.Application.Interfaces
{
    public interface IXERPDbContext
    {
        #region Human Resources
        DbSet<Certificate> Certificates { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        DbSet<EmployeeDependent> EmployeeDependents { get; set; }
        DbSet<EmployeeEducationalBackGround> EmployeeEducationalBackGrounds { get; set; }
        DbSet<EmployeeRank> EmployeeRanks { get; set; }
        DbSet<EmployeeState> EmployeeStates { get; set; }
        DbSet<EmploymentType> EmploymentTypes { get; set; }
        DbSet<LeaveTypes> LeaveTypes { get; set; }
        DbSet<Nationality> Nationalities { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Team> Teams { get; set; }

        #endregion

        #region Payroll
        DbSet<Currencies> Currencies { get; set; }

        #endregion

        #region TimeKeeping and SelfService
        DbSet<ChangeShiftFiling> ChangeShiftFilings { get; set; }

        #endregion

        #region Common
        DbSet<Company> Companies { get; set; }
        DbSet<CompanyRepresentative> CompanyRepresentatives { get; set; }
        DbSet<CostCenter> CostCenters { get; set; }
        DbSet<Industry> Industries { get; set; }
        DbSet<Site> Sites { get; set; }
        DbSet<CompanyClient> CompanyClients { get; set; }
        #endregion


        DbSet<ApplicationUser> ApplicationUsers { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
