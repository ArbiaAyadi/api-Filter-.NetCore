using Location.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Location.Data
{
    public class ApplicationDbContext1 : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext1(DbContextOptions<ApplicationDbContext1> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Visitor> Visitor { get; set; }
        public DbSet<Maison> Maison { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Payment> Payment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
       .HasOne(r => r.Maison)
       .WithMany(m => m.Reviews)
       .HasForeignKey(r => r.MaisonId)
       .OnDelete(DeleteBehavior.Restrict); // ⛔ pas de cascade ici

            // Review → Client (peut garder Cascade si besoin)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Client)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            // Payment → Maison
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Maison)
                .WithMany(m => m.Payments)
                .HasForeignKey(p => p.MaisonId)
                .OnDelete(DeleteBehavior.Restrict);

            // Payment → Client
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Payments)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    }
