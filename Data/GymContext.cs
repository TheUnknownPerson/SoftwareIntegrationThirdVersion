using SoftwareIntegrationThirdVersion.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareIntegrationThirdVersion.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }

        public DbSet<Gym> Gyms { get; set; }

        public DbSet<Exercise> Exercises { get; set; }
    }
}