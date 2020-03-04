using Microsoft.EntityFrameworkCore;

namespace CarsCatalogue.Models
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }
 
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDetails> CarDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForNpgsqlUseIdentityColumns();
        }
    }
}