using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softecnologia.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

       /* [ForeignKey("IdCliente")]
        [Required(ErrorMessage = "El campo Id Cliente es requerido")]
        public Cliente Cliente { get; set; }*/
       
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string NombreCliente { get; set; }
       
       
        [MaxLength(120)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string ApellidosCliente { get; set; }
        

       /* [ForeignKey("IdProduco")]
        [Required(ErrorMessage = "El campo producto es requerido")]
        public Producto IdProducto { get; set; }*/
        
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Nombre producto es requerido")]
        public string NombreProducto { get; set; }
        
        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        public int Cantidad { get; set; }
        
        [Required(ErrorMessage = "El campo Fecha de pedido es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Pedido")]
        public DateTime FechaPedido { get; set; }

        
        [Required(ErrorMessage = "El campo Total es requerido")]
        public int Total { get; set; }

    }
}