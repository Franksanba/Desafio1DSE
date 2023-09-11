using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio_1.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El DUI del cliente es requerido.")]
        [Display(Name = "DUI")]
        [RegularExpression(@"^\d{8}-\d{1}$", ErrorMessage = "El formato del DUI debe ser 12345678-9.")]
        public string DUI { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido.")]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es requerido.")]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del cliente es requerida.")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
    }
}