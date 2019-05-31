using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class SeatContext : DbContext
    {
        public SeatContext(DbContextOptions<SeatContext> options) : base(options)
        {}

        public DbSet<Seat> Seats { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seat>()
                .HasKey(s => s.SeatId)
                .HasName($"PrimaryKey_SeatId");
        }
    }
}
