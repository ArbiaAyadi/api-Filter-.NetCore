namespace Location.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int note { get; set; }

        public string commentaire { get; set; }

        // Relations
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int MaisonId { get; set; }
        public Maison Maison { get; set; }
    }
}
