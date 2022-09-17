using SanguchesBD.Data.Común;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguches.Data.Entidades
{
    public class Sanguchaso : BaseEntity
    {
        //Decorados más los atributos.
        [Required(ErrorMessage = "El Monto de la docena es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int MontoXDocena { get; set; }

        [Required(ErrorMessage = "El tipo de sanguche es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string TipoSanguche { get; set; }

    }
}
