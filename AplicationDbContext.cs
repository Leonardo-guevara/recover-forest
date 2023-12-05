using Entidades;
using Microsoft.EntityFrameworkCore;

namespace recover_forest
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
    }

  
}
