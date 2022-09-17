using Microsoft.EntityFrameworkCore;
using Sanguche.Data.Entidades;
using Sanguches.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguche.Data
{
    public class BDContext : DbContext 
    {
        //Constructor
        public BDContext(DbContextOptions options) : base(options) {
        }
        //Base de dato=Nombre de la tabla de C/u de mis bases
        public DbSet<Sanguchaso> sanguchasos { get; set; }

        public DbSet<PedidoVenta> tiposdeSanguchasos { get; set; }
    }
}
