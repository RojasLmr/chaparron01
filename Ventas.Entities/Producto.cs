using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ventas.Entities
{
    public class Articulo
    {
        [Key]
        public int idarticulo { get; set; }
        public int IdCategoria { get; set; }
        [Required]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public bool condicion { get; set; }
        
        

    }
}
