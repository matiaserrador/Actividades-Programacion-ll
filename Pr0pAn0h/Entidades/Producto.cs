using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributo
        private int Código;
        private string Descripción;
        private int Stock;
        #endregion

        #region Constructores
        public Producto()
        { }

        public Producto(int code, string desc)
        {
            Código = code;
            Descripción = desc;
            Stock = 0;
        }
        #endregion

        #region Métodos
        public void Suma(int Cantidad)
        {
            Stock = Stock + Cantidad;
        }
        public void Resta(int Cantidad)
        {
            Stock = Stock - Cantidad;
        }
        #endregion

        #region Prop
        public int codigo
        {
            set { Código = value; }

            get { return Código; }
        }
        public string descripcion
        {
            set { Descripción = value; }
            get { return Descripción; } 
        }
        public int st0ck
        {
            get { return Stock; }
        }
        #endregion
    }
    
}
