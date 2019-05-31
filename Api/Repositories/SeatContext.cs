using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class SeatRepository : DbContext
    {
        public SeatRepository(DbContextOptions<SeatRepository> options) : base(options)
        {}
        
        public DbSet<Seat> Seats { get; set; }
    }
}
