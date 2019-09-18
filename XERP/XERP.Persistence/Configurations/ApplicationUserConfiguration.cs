using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XERP.Domain.Entities;

namespace XERP.Persistence.Configurations
{
    public class ApplicationUserConfiguration : IdentityUser, IEntityTypeConfiguration<ApplicationUser>
    {


        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.OwnsOne(u => u.AdAccount);
        }

    }
}
