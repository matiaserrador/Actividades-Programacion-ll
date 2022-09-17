using Microsoft.EntityFrameworkCore;
using Sanguches.Data.Entidades;
using SanguchesBD.Data.Común;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguche.Data.Entidades
{
    [Index(nameof(Id), Name = "CodigoPedido", IsUnique = true)]
    public class PedidoVenta:BaseEntity

    {
        [Required(ErrorMessage = "El domicilio es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int CodigoPedido { get; set; }

        [Required(ErrorMessage = "El domicilio es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es obligatoria.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Fecha { get; set; }

        [Required(ErrorMessage = "el Horario del pedido es obligatoria.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Horario { get; set; }

        [Required(ErrorMessage = "El Nombre del cliente es obligatoria.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string NombreCliente { get; set; }
        public List<Sanguchaso> sanguchasos { get; set; } 

    }
}
