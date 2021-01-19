using Microsoft.EntityFrameworkCore;
using Real.DomainModel;

namespace Real.DomainServices.PropertyRepository
{
    public class PropertyContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }

        public PropertyContext(DbContextOptions<PropertyContext> options) 
            : base(options)
        {
            ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                .ToTable("Properties")
                .HasKey(p => p.Id);
        }
    }
}