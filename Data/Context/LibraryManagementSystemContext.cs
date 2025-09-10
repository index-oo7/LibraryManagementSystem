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
            // TODO: Implementirati
        }
    }
}
