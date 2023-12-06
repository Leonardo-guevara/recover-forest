using Entidades;
using Microsoft.EntityFrameworkCore;
using recover_forest.Entidad;

namespace recover_forest
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VentaOferta>().Property(prop => prop.porcentajedescuento)
                .HasPrecision(precision:10, scale:2);
            modelBuilder.Entity<VentaTamanho>().Property(prop => prop.Tamanho).HasDefaultValue(TipoTamanho.pequenho);

            modelBuilder.Entity<Arbol>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Copa>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Familia>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Flores>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Genero>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Origen>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Porte>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<Tree>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");

            modelBuilder.Entity<Venta>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<VentaOferta>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");
            modelBuilder.Entity<VentaTamanho>().Property(prop => prop.create_at).HasDefaultValueSql("GETDATA()");

        }
        public DbSet<Arbol> arboles { get; set; }
        public DbSet<Copa> f_copa { get; set; }
        public DbSet<Familia> familias { get; set; }
        public DbSet<Flores> flores { get; set; }
        public DbSet<Genero> generos { get; set; }
        public DbSet<Origen> origenes { get; set; }
        public DbSet<Porte> Porte { get; set; }
        public DbSet<Tree> tree { get; set; }

        public DbSet<Venta> ventas { get; set; }
        public DbSet<VentaOferta> ventaofertas { get; set; }
        public DbSet<VentaTamanho> Ventatamanhos { get; set; }
    }

  
}
