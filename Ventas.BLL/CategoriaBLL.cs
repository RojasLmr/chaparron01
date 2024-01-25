using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BLL.Interfaces;
using Ventas.DAL;
using Ventas.Entities;

namespace Ventas.BLL
{
    public class CategoriaBLL : ICategoriaRepositorio
    {
        VentasContextoBD db = new VentasContextoBD();

        public List<Categoria> ListarCategoria()
        {
            return db.categoria.ToList();
        }

        public void Actualizar(Categoria categoria)
        {
            db.Entry(categoria).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Categoria categoria)
        {
            db.categoria.Add(categoria);
            db.SaveChanges();
        }

       
       
        public Categoria Buscar(int Id)
        {
            var Bus = db.categoria.Find(Id);
            return Bus;
        }

        public List<Categoria> FiltroNombre(string nombre)
        {
            var query = from x in db.categoria
                        where x.Nombre.Contains(nombre)
                        select x;
            return query.ToList();
        }
    }
}
