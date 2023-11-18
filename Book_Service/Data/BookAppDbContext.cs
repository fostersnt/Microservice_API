using Book_Service.Model;
using Microsoft.EntityFrameworkCore;

namespace Book_Service.Data
{
    public class BookAppDbContext : DbContext
    {
        public BookAppDbContext(DbContextOptions<BookAppDbContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasKey(b => b.BookId);
            modelBuilder.Entity<Book>().HasData(
                new Book{ BookId = 1, Name = "The Spider" },
                new Book{ BookId = 2, Name = "The Ananse Story" }
                );

        }

        public DbSet<Book> Books { get; set; }
    }
}
