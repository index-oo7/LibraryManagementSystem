using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Data.Configurations
{
    public class BookConfiguration : EntityTypeConfiguration<Models.Book>
    {
        protected override void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(b => b.BookId);

            builder.Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Genre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.PublicationYear)
                .HasColumnType("int");

            builder.Property(b => b.TotalCopies)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(b => b.AvailableCopies)
                .IsRequired()
                .HasDefaultValue(1);

            ConfigureBase(builder);
        }
    }
}
