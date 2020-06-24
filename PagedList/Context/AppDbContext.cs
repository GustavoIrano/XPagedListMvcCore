using Microsoft.EntityFrameworkCore;
using PagedList.Models;

namespace PagedList.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
