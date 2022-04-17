using BookApp.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Infra.Data.Sql
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Core.Domain.Book> Books { get; set; }
    }
}
