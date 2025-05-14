using System.ComponentModel.DataAnnotations;

namespace Location.Models
{
    public class Admin
    {
        [Key]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}