using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using XERP.Domain.Entities;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.CompanyResource;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.TimeKeeping;
using XERP.Domain.Entities.TimeKeeping.Approvals;
using XERP.Domain.Entities.Payroll;
using XERP.Domain.Entities.Payroll.Approvals;

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
        DbSet<Regions> Regions { get; set; }
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


        #region Time Keeping
        DbSet<ChangeShiftFiling> ChangeShiftFilings { get; set; }
        DbSet<DailyTimeRecord> DailyTimeRecords { get; set; }
        DbSet<EmployeeApprovers> EmployeeApprovers { get; set; }
        DbSet<LeaveFiling> LeaveFilings { get; set; }
        DbSet<OBFiling> OBFilings { get; set; }
        DbSet<OTFiling> OTFilings { get; set; }
        DbSet<ShiftSchedules> ShiftSchedules { get; set; }
        DbSet<TimeLogFiling> TimeLogFilings { get; set; }
        DbSet<TimeLogType> TimeLogTypes { get; set; }
        DbSet<TimeSheet> TimeSheets { get; set; }

        DbSet<ChangeShiftApproval> ChangeShiftApprovals { get; set; }
        DbSet<LeaveApproval> LeaveApprovals { get; set; }
        DbSet<OBApproval> OBApprovals { get; set; }
        DbSet<OTApproval> OTApprovals { get; set; }
        DbSet<TimelogApproval> TimelogApprovals { get; set; }

        #endregion Time Keeping


        #region Payroll
        DbSet<Currencies> Currencies { get; set; }
        DbSet<CurrencyDetails> CurrencyDetails { get; set; }
        DbSet<EmployeePayrollItems> EmployeePayrollItems { get; set; }
        DbSet<EmployeePayrollScheme> EmployeePayrollScheme { get; set; }
        DbSet<HourTypes> HourTypes { get; set; }
        DbSet<LoanFiling> LoanFiling { get; set; }
        DbSet<Loans> Loans { get; set; }
        DbSet<ParameterRates> ParameterRates { get; set; }
        DbSet<Parameters> Parameters { get; set; }
        DbSet<Payroll> Payroll { get; set; }
        DbSet<PayrollEmployeeDetails> PayrollEmployeeDetails { get; set; }
        DbSet<PayrollEmployees> PayrollEmployees { get; set; }
        DbSet<PayrollItems> PayrollItems { get; set; }
        DbSet<PayrollItemTypes> PayrollItemTypes { get; set; }
        DbSet<PayrollPeriod> PayrollPeriods { get; set; }
        DbSet<ReimbursementFiling> ReimbursementFiling { get; set; }

        //Payroll Approvals
        DbSet<LoanApproval> LoanApproval { get; set; }
        DbSet<ReimbursementApproval> ReimbursementApproval { get; set; }
        #endregion Payroll
    }
}
