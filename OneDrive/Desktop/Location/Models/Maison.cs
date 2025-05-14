using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



   
namespace Location.Models
    {
        public class Maison
        {
            public int MaisonId { get; set; }

            [Required]
            public string adresse { get; set; }

            public string zone { get; set; }

            public float prix { get; set; }

            public string Genre { get; set; }

            public bool disponibilite { get; set; }

            // Relations
            public int OwnerId { get; set; }
            public Owner Owner { get; set; }

            public ICollection<Review>? Reviews { get; set; } = new List<Review>();
            public ICollection<Payment>? Payments { get; set; } = new List<Payment>();


        // Champs de filtrage
        [NotMapped]
        public string? AdresseFilter { get; set; }

        [NotMapped]
        public string? ZoneFilter { get; set; }

        [NotMapped]
        public float? MinPrix { get; set; }

        [NotMapped]
        public float? MaxPrix { get; set; }

        [NotMapped]
        public string? GenreFilter { get; set; }

        [NotMapped]
        public bool? DisponibiliteFilter { get; set; }


    }
    }

