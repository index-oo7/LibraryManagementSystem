namespace LibraryManagementSystem.Models
{
    public class Member : BaseEntity
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime MembershipDate { get; set; }
        public bool IsActive { get; set; }
        public int MaxBooksAllowed { get; set; }

        // Navigation properties 1-M
        public virtual ICollection<Loan> Loans { get; set; } = new HashSet<Loan>();
    }
}
