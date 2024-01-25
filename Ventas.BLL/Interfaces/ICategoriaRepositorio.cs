using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.BLL.Interfaces
{
    public interface ICategoriaRepositorio
    {
        void Agregar(Categoria categoria);
        void Actualizar(Categoria categoria);
        List<Categoria> ListarCategoria();
        Categoria Buscar(int Id);
        List<Categoria> FiltroNombre(string nombre);

        
    }
}
