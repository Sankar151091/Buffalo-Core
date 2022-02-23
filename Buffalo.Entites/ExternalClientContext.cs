using Buffalo.Entities.Configuration;
using Buffalo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Buffalo.Entities
{
    public class ExternalClientContext : DbContext
    {
        public ExternalClientContext(DbContextOptions<ExternalClientContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }

        public DbSet<Client> Clients { get; set; }
    }
}
