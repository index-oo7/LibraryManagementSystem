using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data.Configurations
{
    public class LoanConfiguration : EntityTypeConfiguration<Models.Loan>
    {
        protected override void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("Loan");

            builder.HasKey(l => l.LoanId);

            builder.Property(l => l.BookId)
                .IsRequired();

            builder.Property(l => l.MemberId)
                .IsRequired();

            builder.Property(l => l.LoanDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(l => l.DueDate)
                .IsRequired();

            builder.Property(l => l.ReturnDate)
                .HasColumnType("date");

            builder.Property(l => l.FineAmount)
                .IsRequired()
                .HasColumnType("decimal(10,2)")
                .HasDefaultValue(0);

            // TODO: Mozda neki WellKnownValues za status
            builder.Property(l => l.Status)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("Active");

            // Definisanje Delete Behavior-a
            builder.HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            ConfigureBase(builder);
        }
    }
}
