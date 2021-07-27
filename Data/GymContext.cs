using SoftwareIntegrationThirdVersion.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareIntegrationThirdVersion.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Gym> Gyms { get; set; }
    }
}