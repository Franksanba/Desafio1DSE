using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio_1.Models
{
    public class Sucursal
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El departamento de la sucursal es requerido.")]
        [Display(Name = "Departamento")]
        [StringLength(50, ErrorMessage = "El departamento no puede tener más de 50 caracteres.")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "El municipio de la sucursal es requerido.")]
        [Display(Name = "Municipio")]
        [StringLength(50, ErrorMessage = "El municipio no puede tener más de 50 caracteres.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "El encargado de la sucursal es requerido.")]
        [Display(Name = "Encargado de Sucursal")]
        [StringLength(100, ErrorMessage = "El nombre del encargado no puede tener más de 100 caracteres.")]
        public string EncargadoSucursal { get; set; }
    }
}