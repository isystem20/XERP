using Microsoft.EntityFrameworkCore;
using System;
using XERP.App.Interfaces;

namespace XERP.Persistence
{
    public class AppDBContext : DbContext //, IAppDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }
    }
}
