using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using XERP.Application.Interfaces;
using XERP.Domain.Entities;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.CompanyResource;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Entities.TimeKeeping;
using XERP.Domain.Entities.TimeKeeping.Approvals;
using XERP.Domain.Entities.Payroll;
using XERP.Domain.Entities.Payroll.Approvals;

namespace XERP.Persistence
{
    public class XERPDbContext : IdentityDbContext, IXERPDbContext
    {
        public XERPDbContext(DbContextOptions<XERPDbContext> options) : base(options)
        {
        }
        
        #region Human Resources
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        public DbSet<EmployeeDependent> EmployeeDependents { get; set; }
        public DbSet<EmployeeEducationalBackGround> EmployeeEducationalBackGrounds { get; set; }
        public DbSet<EmployeeRank> EmployeeRanks { get; set; }
        public DbSet<EmployeeState> EmployeeStates { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<LeaveTypes> LeaveTypes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        #endregion

        #region TimeKeeping and SelfService
        public DbSet<ChangeShiftFiling> ChangeShiftFilings { get; set; }
        public DbSet<DailyTimeRecord> DailyTimeRecords { get; set; }
        public DbSet<EmployeeApprovers> EmployeeApprovers { get; set; }
        public DbSet<LeaveFiling> LeaveFilings { get; set; }
        public DbSet<OBFiling> OBFilings { get; set; }
        public DbSet<OTFiling> OTFilings { get; set; }
        public DbSet<ShiftSchedules> ShiftSchedules { get; set; }
        public DbSet<TimeLogFiling> TimeLogFilings { get; set; }
        public DbSet<TimeLogType> TimeLogTypes { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }

        // Timekeeping Approval
        public DbSet<ChangeShiftApproval> ChangeShiftApprovals { get; set; }
        public DbSet<LeaveApproval> LeaveApprovals { get; set; }
        public DbSet<OBApproval> OBApprovals { get; set; }
        public DbSet<OTApproval> OTApprovals { get; set; }
        public DbSet<TimelogApproval> TimelogApprovals { get; set; }        
        #endregion Timekeeping

        #region Payroll
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<CurrencyDetails> CurrencyDetails { get; set; }
        public DbSet<EmployeePayrollItems> EmployeePayrollItems { get; set; }
        public DbSet<EmployeePayrollScheme> EmployeePayrollScheme { get; set; }
        public DbSet<HourTypes> HourTypes { get; set; }
        public DbSet<LoanFiling> LoanFiling { get; set; }
        public DbSet<Loans> Loans { get; set; }
        public DbSet<ParameterRates> ParameterRates { get; set; }
        public DbSet<Parameters> Parameters { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<PayrollEmployeeDetails> PayrollEmployeeDetails { get; set; }
        public DbSet<PayrollEmployees> PayrollEmployees { get; set; }
        public DbSet<PayrollItems> PayrollItems { get; set; }
        public DbSet<PayrollItemTypes> PayrollItemTypes { get; set; }
        public DbSet<PayrollPeriod> PayrollPeriods { get; set; }
        public DbSet<ReimbursementFiling> ReimbursementFiling { get; set; }

        //Payroll Approvals
        public DbSet<LoanApproval> LoanApproval { get; set; }
        public DbSet<ReimbursementApproval> ReimbursementApproval { get; set; }
        #endregion Payroll
        
       	#region Common
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyRepresentative> CompanyRepresentatives { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<CompanyClient> CompanyClients { get; set; }
        #endregion


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<SystemRole> SystemRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XERPDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
