using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Persistence
{
    public class XERPInitializer
    {
        private readonly Dictionary<string, Employee> Employees = new Dictionary<string, Employee>();

        public static void Initialize(XERPDbContext context)
        {
            var initializer = new XERPInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(XERPDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                return; // Db has been seeded
            }

            SeedDefaultUsers(context);

        }

        private void SeedDefaultUsers(XERPDbContext context)
        {
            var regions = new[]
            {
                new Region { RegionId = 1, RegionDescription = "Eastern"},
                new Region { RegionId = 2, RegionDescription = "Western"},
                new Region { RegionId = 3, RegionDescription = "Northern"},
                new Region { RegionId = 4, RegionDescription = "Southern"}
            };

            context.Region.AddRange(regions);

            context.SaveChanges();
        }


    }
}
