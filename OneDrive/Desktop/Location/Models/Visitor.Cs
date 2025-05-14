namespace Location.Models
{
    public class Visitor
    {
        public int VisitorId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

