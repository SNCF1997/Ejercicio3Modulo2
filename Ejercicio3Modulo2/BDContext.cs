using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3Modulo2EFCore
{
    public class BDContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor>().Property(prop => prop.IdActor).HasColumnName("id");
            modelBuilder.Entity<Actor>().Property(prop => prop.NombreActor).HasColumnName("nombre");
            modelBuilder.Entity<Actor>().Property(prop => prop.ApellidoActor).HasColumnName("apellido");
            modelBuilder.Entity<Actor>().Property(prop => prop.NomArtActor).HasColumnName("nombre_artistico");
            modelBuilder.Entity<Actor>().Property(prop => prop.EdadActor).HasColumnName("edad");
            modelBuilder.Entity<Actor>().Property(prop => prop.NacionalidadActor).HasColumnName("nacionalidad");
            modelBuilder.Entity<Actor>().Property(prop => prop.GeneroActor).HasColumnName("genero");

            base.OnModelCreating(modelBuilder);
        }
    }
}
