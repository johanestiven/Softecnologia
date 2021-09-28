using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softecnologia.Models
{
    public class CategoriaProducto
    {
        [Key]
        public int CategoriaProductoId { get; set; }
    
       [ForeignKey("IdProducto")]
        public Producto Producto  { get; set; }

        [Required(ErrorMessage = "El campo Stock es requerido")]
        public int Stock { get; set; }
    
    }
}