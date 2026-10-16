using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
               new Currency() { Id = 1, Tittle = "INR", Description = "Indian INR" },
                new Currency() { Id = 2, Tittle = "Dollar", Description = "Dollar" },
                new Currency() { Id = 3, Tittle = "Euro", Description = "Euro" },
                new Currency() { Id = 4, Tittle = "Dinar", Description = "Dinar " }
               );
            modelBuilder.Entity<Language>().HasData(
             new Language() { Id = 1, tittle = "Hindi", Description = "Hindi" },
              new Language() { Id = 2, tittle = "Odia", Description = "Odia" },
              new Language() { Id = 3, tittle = "Telugu", Description = "Telugu" },
              new Language() { Id = 4, tittle = "Urdu", Description = "Urdu " }
             );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
    }
}
