using FaltaUno.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FaltaUno.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Matches> Matches { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional de las relaciones
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Match)
                .WithMany(m => m.Requests)
                .HasForeignKey(r => r.MatchId);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Player)
                .WithMany()
                .HasForeignKey(r => r.PlayerId);
        }
    }
}