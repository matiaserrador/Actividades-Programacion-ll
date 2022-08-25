using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    public class Persona
    {
        private string Nombre;
        private long DNI;
        private DateTime FechaNacimiento;

        public Persona()
        {

        }
        public Persona(string nombre, long dni, DateTime fechanacimiento)
        {
            Nombre = nombre;
            DNI = dni;
            FechaNacimiento = fechanacimiento;
        }
        public string pNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public long pDNI
        {
            set { pDNI = value; }
            get { return DNI; }
        }

        public DateTime pFechaNacimiento
        {
            set { FechaNacimiento = value; }
            get { return FechaNacimiento; }
        }
        public int FechaEdad(int AñoNuevo)
        {
            DateTime datetime = DateTime.Today;
            int Edad = datetime.Year - AñoNuevo;
            return Edad;
        }

    }
}
