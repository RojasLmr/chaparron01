using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.DAL
{
    public class VentasContextoBD : DbContext
    {
        public VentasContextoBD() 
            : base("name=Cadena1")
        {
        }

        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Articulo> articulo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>().ToTable("Articulos");
        }
    }
}
