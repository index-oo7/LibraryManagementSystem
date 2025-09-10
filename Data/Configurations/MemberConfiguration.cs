using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Data.Configurations
{
    public class MemberConfiguration : EntityTypeConfiguration<Models.Member>
    {
        public override void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Member");

            builder.HasKey(m => m.MemberId);

            builder.Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(m => m.Address)
                .HasMaxLength(200);

            builder.Property(m => m.MembershipDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(m => m.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(m => m.MaxBooksAllowed)
                .IsRequired()
                .HasDefaultValue(5);

        }
    }
}
