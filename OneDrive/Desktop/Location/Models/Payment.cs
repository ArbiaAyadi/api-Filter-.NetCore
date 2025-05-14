using System;

namespace Location.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public float montant { get; set; }

        public DateTime date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int MaisonId { get; set; }
        public Maison Maison { get; set; } = null!;

        public float commissionAdmin => montant * 0.05f;

        // Relations
      
    }
}
