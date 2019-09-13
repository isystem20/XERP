using Microsoft.EntityFrameworkCore;
using XERP.Persistence.Infrastructure;

namespace XERP.Persistence
{
    public class XERPDbContextFactory : DesignTimeDbContextFactoryBase<XERPDbContext>
    {
        protected override XERPDbContext CreateNewInstance(DbContextOptions<XERPDbContext> options)
        {
            return new XERPDbContext(options);
        }
    }
}
