using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Persistence.Configurations.HumanResource
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
