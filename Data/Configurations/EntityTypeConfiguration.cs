using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Data.Configurations
{
    public abstract class EntityTypeConfiguration<T> where T : class
    {
        protected abstract void Configure(EntityTypeBuilder<T> builder);

        protected virtual void ConfigureBase(EntityTypeBuilder<T> builder)
        {
            if (builder != null)
            {
                builder.Property("CreatedDate")
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");

                builder.Property("UpdatedDate")
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");

                builder.Property("CreatedBy")
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property("UpdatedBy")
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property("IsDeleted")
                    .IsRequired()
                    .HasDefaultValue(false);

                builder.HasQueryFilter(e => !EF.Property<bool>(e, "IsDeleted"));
            }
        }
    }
}
