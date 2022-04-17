using Book.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Book.Infra.Data.Sql
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Core.Domain.Book> Books { get; set; }
    }
}
