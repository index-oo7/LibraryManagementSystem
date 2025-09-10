namespace LibraryManagementSystem.Models
{
    public class Loan : BaseEntity
    {
        public int LoanId { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; } = 0;

        //TODO: Mozda neki WellKnownValues za status
        public string Status { get; set; } = "Active"; // Active, Returned, Overdue

        // M-1
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
