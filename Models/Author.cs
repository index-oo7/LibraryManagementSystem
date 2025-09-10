namespace LibraryManagementSystem.Models
{
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime? BirthDate { get; set; }

        // Navigation properties M-M
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
