using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.Security;

namespace XERP.Persistence.Configurations.Security
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.IssuedUtc)
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
            builder.Property(e => e.ExpiresUtc)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(e => e.Token)
                .IsRequired();
            builder.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
