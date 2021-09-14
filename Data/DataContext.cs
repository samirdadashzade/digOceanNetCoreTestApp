using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;


namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Samir", LastName = "Dadash", Address = "DC", Country = "USA", Mobile = 111 },
                new User { Id = 2, FirstName = "Ilhame", LastName = "Dadash", Address = "DC", Country = "USA", Mobile = 222 },
                new User { Id = 3, FirstName = "Nunus", LastName = "Dadash", Address = "DC", Country = "USA", Mobile = 333 }
            );
        }
    }
}
