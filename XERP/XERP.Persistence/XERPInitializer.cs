using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities;
using XERP.DataModel.HR;
using XERP.Domain.Entities.HumanResource;
using static XERP.Persistence.XERPDbContext;
using XERP.Domain.Entities.Common;

namespace XERP.Persistence
{
    public class XERPInitializer
    {
        private readonly Dictionary<string, Employee> Employees = new Dictionary<string, Employee>();

        public static void Initialize(XERPDbContext context, UserManager<ApplicationUser> userManager)
        {
            var initializer = new XERPInitializer();
            initializer.SeedEverything(context, userManager);
        }

        public void SeedEverything(XERPDbContext context, UserManager<ApplicationUser> userManager)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return; // Db has been seeded
            }

            SeedUserRoles(context);

            SeedDefaultUsers(userManager);

        }

        private void SeedUserRoles(XERPDbContext context)
        {
            var roles = new[]
            {
                new SystemRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new SystemRole { Name = "Member", NormalizedName = "Member".ToUpper() },
                new SystemRole { Name = "Agent", NormalizedName = "Agent".ToUpper() }
            };

            context.SystemRoles.AddRange(roles);

            context.SaveChanges();
        }


        private void SeedDefaultUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync("nexarcadmin@nexitph.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "nexarcadmin@nexitph.com",
                    Email = "nexarcadmin@nexitph.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "S6fmpK_nxN95{](C").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }


    }
}
