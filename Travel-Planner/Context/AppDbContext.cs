using Microsoft.EntityFrameworkCore;
using Travel_Planner.Data;

namespace Travel_Planner.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }

    }
}
