using Microsoft.EntityFrameworkCore;
using watchlistScreener.Models.Entities;

namespace watchlistScreener.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
