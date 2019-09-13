using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Interfaces
{
    public interface IXERPDbContext
    {
        DbSet<Employee> Employees { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
