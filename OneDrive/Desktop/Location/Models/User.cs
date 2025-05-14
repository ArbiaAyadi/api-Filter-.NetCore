using System.ComponentModel.DataAnnotations;
using Location.Models;

namespace Location.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]

        public string nom { get; set; } = string.Empty;
        public string prenom { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
        public string motDePasse { get; set; } = string.Empty;
        public Admin Admin { get; set; }

        public Visitor? Visiteur { get; set; }
        public Owner? Owner { get; set; }
        public Client? Client { get; set; }
    }
}