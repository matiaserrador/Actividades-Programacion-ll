using Sanguche.Data.Entidades;
using Sanguches.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanguche.Data
{
    public class BDContext : DbContext 
    {
        //Base de dato
        public DbSet<Sanguchaso> sanguchasos { get; set; }

        public DbSet<PedidoVenta> tiposdeSanguchasos { get; set; }
    }
}
