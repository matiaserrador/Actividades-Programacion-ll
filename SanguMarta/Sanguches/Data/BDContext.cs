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
        public DbSet<Sanguchaso> Sanguchasos { get; set; }

        
    }
}
