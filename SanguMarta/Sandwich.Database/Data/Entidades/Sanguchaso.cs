using Microsoft.EntityFrameworkCore;
using SanguchesBD.Data.Común;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguches.Data.Entidades
{
    //CLAVE UNICA
    [Index(nameof (Id),Name="codigo",IsUnique=true )]
    public class Sanguchaso : BaseEntity //aplico herencia
    {
        //Decorados más los atributos. Con restricciones
        [Required(ErrorMessage = "El Monto de la docena es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int MontoXDocena { get; set; }

        [Required(ErrorMessage = "El tipo de sanguche es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string TipoSanguche { get; set; }
        [Required(ErrorMessage = "El tipo de sanguche es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int codigo { get; set; }


    }
}
