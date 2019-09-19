using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using XERP.Application.Interfaces;
using XERP.Domain.Entities;
using XERP.Domain.Entities.Common;
using XERP.Domain.Entities.CompanyResource;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Entities.Payroll;
using XERP.Domain.Entities.Security;
using XERP.Domain.Entities.TimeKeeping;

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

        #region Payroll
        public DbSet<Currencies> Currencies { get; set; }

        #endregion

        #region TimeKeeping and SelfService
        public DbSet<ChangeShiftFiling> ChangeShiftFilings { get; set; }

        #endregion


        #region Security
        DbSet<RefreshToken> RefreshTokens { get; set; }
        #endregion

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
