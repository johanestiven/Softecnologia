using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softecnologia.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        /*[ForeignKey("IdPedido")]
        [Required(ErrorMessage = "El campo Id Pedido es requerido")]
        public Pedido Pedido { get; set; }*/

        [MaxLength(25)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
       
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string Apellidos { get; set; }
       
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo Dirección es requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Celular es requerido")]       
        public int Celular { get; set; }

        [Required(ErrorMessage = "El campo E-mail es requerido")]
        [Display(Name = "E-mail")]        
        public string Email { get; set; }
    }
}