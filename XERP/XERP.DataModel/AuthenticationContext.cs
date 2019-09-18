using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.DataModel.HR;
using XERP.DataModel.PAYROLL;
using XERP.DataModel.SYSTEM;
using XERP.Domain.Entities.Payroll;

namespace XERP.DataModel
{
    public class AuthenticationContext : IdentityDbContext
    {

        #region System Datasets
        public DbSet<ClientCompanies> ClientCompanies { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Industries> Industries { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<UserModules> UserModules { get; set; }
        #endregion

        #region HR Datasets
        public DbSet<Certificates> Certificates { get; set; }
        public DbSet<CostCenters> CostCenters { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<EmployeeCertifications> EmployeeCertifications { get; set; }
        public DbSet<EmployeeDependents> EmployeeDependents { get; set; }
        public DbSet<EmployeeEducationalHistory> EmployeeEducationalHistory { get; set; }
        public DbSet<EmployeePreviousER> EmployeePreviousER { get; set; }
        public DbSet<EmployeeRanks> EmployeeRanks { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeStates> EmployeeStates { get; set; }
        public DbSet<EmployeeTypes> EmployeeTypes { get; set; }
        public DbSet<Nationalities> Nationalities { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<PreviousEmployers> PreviousEmployers { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<Sites> Sites { get; set; }
        #endregion

        #region Payroll Datasets
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<CurrencyDetails> MyProperty { get; set; } //Subject for update
        public DbSet<DayTypes> DayTypes { get; set; }
        public DbSet<EmployeePayrollItems> EmployeePayrollItems { get; set; }
        //public DbSet<EmployeePayrollScheme> EmployeePayrollScheme { get; set; }
        public DbSet<HourTypes> HourTypes { get; set; }
        public DbSet<Loans> Loans { get; set; }
        public DbSet<ParameterRates> ParameterRates { get; set; }
        public DbSet<Parameters> Parameters { get; set; }
        public DbSet<PayrollItems> PayrollItems { get; set; }
        public DbSet<PayrollItemTypes> PayrollItemTypes { get; set; }
        public DbSet<PayrollPeriods> PayrollPeriods { get; set; }
        #endregion

        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Seed Role
            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new ApplicationRole { Name = "Member", NormalizedName = "Member".ToUpper() },
                new ApplicationRole { Name = "Agent", NormalizedName = "Agent".ToUpper() }
                );
                //builder.Entity<Profile>(entity => {
                //    entity.HasIndex(e => e.UserId).IsUnique();
                //});
            base.OnModelCreating(builder);
        }

        public static void SeedUser(UserManager<ApplicationUsers> userManager)
        {
            if (userManager.FindByEmailAsync("sysadmin@xerp.com").Result == null)
            {
                ApplicationUsers user = new ApplicationUsers
                {
                    UserName = "sysadmin@xerp.com",
                    Email = "sysadmin@xerp.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Password@123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }


    }
}
