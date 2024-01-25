using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BLL.Interfaces;
using Ventas.DAL;
using Ventas.Entities;

namespace Ventas.BLL
{
    public class ProductoBLL : IProductoRepositorio
    {
        VentasContextoBD db = new VentasContextoBD();

        public void Actualizar(Articulo articulo)
        {
            db.Entry(articulo).State = EntityState.Modified;
            db.SaveChanges();
        }
        public Articulo Buscar(int Id)
        {
            var Bus = db.articulo.Find(Id);
            return Bus;
        }
        public void Agregar(Articulo articulo)
        {
            db.articulo.Add(articulo);
            db.SaveChanges();
        }

        public List<Articulo> ListarProductos()
        {
            return db.articulo.ToList();
        }

        public List<Articulo> ListarProductos(int? IdCategoria, string nombreProducto)
        {
            throw new NotImplementedException();
        }

        public List<Articulo> ListarxNombre(string texto)
        {
            var query = from x in db.articulo
                        where x.nombre.Contains(texto)
                        select x;
            return query.ToList();
        }

        public List<Articulo> Filtro(int id)
        {
            var query = from x in db.articulo
                        where x.idarticulo == id
                        select x;
            return query.ToList();
        }

        public List<Articulo> ListarProductosOrdenadosPorNombre()
        {
            var query = from x in db.articulo
                        orderby x.nombre // Ordena por el campo ascendente (A-Z).
                        select x;
            return query.ToList();
        }

    }
}
