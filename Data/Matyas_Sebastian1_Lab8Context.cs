using Microsoft.EntityFrameworkCore;

namespace Matyas_Sebastian1_Lab8.Data
{
    public class Matyas_Sebastian1_Lab8Context : DbContext
    {
        public Matyas_Sebastian1_Lab8Context(DbContextOptions<Matyas_Sebastian1_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Matyas_Sebastian1_Lab8.Models.Book> Book { get; set; }

        public DbSet<Matyas_Sebastian1_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Matyas_Sebastian1_Lab8.Models.Category> Category { get; set; }

        public DbSet<Matyas_Sebastian1_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
