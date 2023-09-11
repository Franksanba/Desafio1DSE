using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio_1.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es requerida.")]
        [Display(Name = "Fecha del Pedido")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El cliente es requerido.")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "El monto total es requerido.")]
        [Display(Name = "Monto Total")]
        [DataType(DataType.Currency)]
        public decimal MontoTotal { get; set; }
    }

}