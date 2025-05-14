using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Location.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public float budget { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        // Relations
        public ICollection<Maison>? Maisons { get; set; } = new List<Maison>();
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Payment>? Payments { get; set; }

        [NotMapped]

        public object Payment { get; internal set; }
    }
}
