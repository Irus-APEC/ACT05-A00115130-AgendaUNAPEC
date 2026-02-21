using AgendaUNAPEC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaUNAPEC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contacto> Contactos => Set<Contacto>();
    }
}