using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.BLL.Interfaces
{
    public interface IProductoRepositorio
    {
        void Agregar(Articulo articulo);
        void Actualizar(Articulo articulo);
        List<Articulo> ListarProductos();
        Articulo Buscar(int Id);
        List<Articulo> ListarxNombre(string texto);
        List<Articulo> Filtro(int id);

        List<Articulo> ListarProductosOrdenadosPorNombre();
    }
}


    
