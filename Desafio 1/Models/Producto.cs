using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio_1.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        [Display(Name = "Nombre")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La categoría del producto es requerida.")]
        [Display(Name = "Categoría")]
        [StringLength(50, ErrorMessage = "La categoría no puede tener más de 50 caracteres.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El precio de venta del producto es requerido.")]
        [Display(Name = "Precio de Venta")]
        [DataType(DataType.Currency)]
        public decimal PrecioVenta { get; set; }
    }
}