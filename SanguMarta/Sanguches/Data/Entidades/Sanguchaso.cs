using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguches.Data.Entidades
{
    public class Sanguchaso
    {
        //Decorados más los atributos.
        [Required(ErrorMessage = "El Monto a pagar es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Monto { get; set; }


        [Required(ErrorMessage = "El pedido es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Pedido { get; set; }

        [Required(ErrorMessage = "El domicilio es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "El tipo de sanguche es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string TipoSanguche { get; set; }

        [Required(ErrorMessage = "La cantidad de sanguches es obligatoria.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es obligatoria.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Fecha { get; set; }

    }
}
