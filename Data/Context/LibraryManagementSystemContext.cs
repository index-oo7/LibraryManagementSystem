using System.Data.Entity;

namespace LibraryManagementSystem.Data.Context
{
    public class LibraryManagementSystemContext : DbContext
    {
        public LibraryManagementSystemContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LibraryManagementSystemContext>());
        }

        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Member> Members { get; set; }
        public DbSet<Models.Loan> Loans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(LibraryManagementSystemContext).Assembly);

            modelBuilder.Entity<Models.Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .Map(m =>
                {
                    m.ToTable("BookAuthor");
                    m.MapLeftKey("BookId");
                    m.MapRightKey("AuthorId");
                });

            modelBuilder.Entity<Models.Book>()
                .HasIndex(b => b.ISBN)
                .IsUnique();

            modelBuilder.Entity<Models.Member>()
                .HasIndex(m => m.Email)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
