using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Persistence.Configurations.HumanResource
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.MiddleName)
                .HasMaxLength(20);
            builder.Property(e => e.Suffix)
                .HasMaxLength(20);
            builder.Property(e => e.BirthDate)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(e => e.BirthPlace)
                .HasMaxLength(200);
            builder.Property(e => e.CivilStatus)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasOne(d => d.Nationality)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_Employee_Nationality");
            builder.Property(e => e.CreatedById)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.CreatedAt)
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValue("getdate()");
            builder.Property(e => e.LastModifiedById)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.LastModifiedAt)
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValue("getdate()");
            builder.Property(e => e.VersionNo)
                .HasDefaultValue("((1))");
            builder.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValue("ACTIVE");
        }

    }
}
