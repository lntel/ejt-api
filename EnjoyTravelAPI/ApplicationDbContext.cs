using EnjoyTravelAPI.Configurations;
using EnjoyTravelAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnjoyTravelAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfigurations());
        }
    }
}
