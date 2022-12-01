using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        #region ATRIBUTOS
        private int id;
        private int dni;
        private string fecha;
        private int hora;
        private string pagado;
        private string barbero;
        private int idcliente;
        
        #endregion

        #region Propiedad/Encapsulamiento
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int HORA
        {
            get { return hora; }
            set { hora = value; }
        }
        public string PAGADO
        {
            get { return pagado; }
            set { pagado = value; }
        }
        public string BARBERO
        {
            get { return barbero; }
            set { barbero = value; }
        }
        public int IDCLIENTE
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        #endregion

        #region Constructor
        //public Turnos()
        //{
        //    dni = 0;
        //    fecha = DateTime.Now;
        //    hora = String.Empty;
        //    pagado = String.Empty;
        //    barbero = String.Empty;
        //}

        public Turnos() { }
        public Turnos(int dni, string fecha, int hora,string pagado, string barbero,int idcliente)
        {
            DNI = dni;
            FECHA = fecha;
            HORA = hora;
            PAGADO = pagado;
            BARBERO = barbero;
            IDCLIENTE = idcliente;
        }
        #endregion

        #region Método Pagado
        public void PagadoPagado(bool pagadoPay)
        {
            if (pagadoPay == true)
            {
                pagado = "si";
            }
            else
            {
                pagado = "no";
            }
        }
        #endregion
    }
}

