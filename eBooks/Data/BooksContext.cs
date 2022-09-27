
using Microsoft.EntityFrameworkCore;
using eBooks.Models;

namespace eBooks.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Books> Books { get; set; }
    }
}
