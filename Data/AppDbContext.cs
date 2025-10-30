using Microsoft.EntityFrameworkCore;
using EventRegSystem.Models;

namespace EventRegSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<EventRegistration> EventRegistrations { get; set; }
    }
}
