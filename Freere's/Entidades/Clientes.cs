using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        #region Atributos
        private int id;
        private int codcliente;
        private string nombre;
        #endregion

        #region Constructor
        public Clientes()
        {
            codcliente = 0;
            nombre = string.Empty;
        }
        #endregion

        #region Propiedades/Encapsulamiento
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int CodCliente
        {
            get { return codcliente; }
            set { codcliente = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        public Clientes(int codcliente,string nombre)
        {
            CodCliente = codcliente;
            NOMBRE = nombre;
        }
    }
}
