using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Data.Configurations
{
    public class AuthorConfiguration : EntityTypeConfiguration<Models.Author>
    {
        protected override void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Biography)
                .HasMaxLength(1000);

            builder.Property(a => a.BirthDate)
                .HasColumnType("date");

            ConfigureBase(builder);
        }
    }
}
