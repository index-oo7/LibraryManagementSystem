using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Data.Configurations
{
    public class BaseEntityConfiguration : EntityTypeConfiguration<Models.BaseEntity>
    {
        protected override void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.Property(a => a.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(a => a.UpdatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(a => a.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.UpdatedBy)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
