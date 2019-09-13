using Microsoft.EntityFrameworkCore;
using System;
using XERP.Application.Interfaces;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Persistence
{
    public class XERPDbContext : DbContext, IXERPDbContext
    {
        public XERPDbContext(DbContextOptions<XERPDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XERPDbContext).Assembly);
        }

    }
}
