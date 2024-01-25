using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ventas.Entities
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Falta Nombre")]
        public string Nombre { get; set; }

        public string descripcion { get; set; }
        public bool condicion { get; set; }
        

        
      
    }
}



