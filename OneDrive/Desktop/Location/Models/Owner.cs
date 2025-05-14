using System.Collections.Generic;

namespace Location.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        // Navigation
        public ICollection<Maison> Maisons { get; set; } = new List<Maison>();
    }
}
