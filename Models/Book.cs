namespace LibraryManagementSystem.Models
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int? PublicationYear { get; set; }
        public int TotalCopies { get; set; } = 1;
        public int AvailableCopies { get; set; } = 1;

        // Navigation properties M-1
        public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        public virtual ICollection<Loan> Loans { get; set; } = new HashSet<Loan>();
    }
}
