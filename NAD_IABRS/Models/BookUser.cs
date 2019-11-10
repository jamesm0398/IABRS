namespace NAD_IABRS.Models
{
    public class BookUser
    {
        [key]
        public int BookId { get; set; }
        [key]
        public int UserId { get; set; }
        public Book Book { get; set; }
        public User User{ get; set; }
    }
}