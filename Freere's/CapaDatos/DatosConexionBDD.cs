using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DatosConexionBDD
    {
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-1KBC539\SQLEXPRESS;Initial Catalog=Barberox;Integrated Security=True";
        
        #region Constructor
        public DatosConexionBDD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region Abrir y Cerrar la Conexión
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        #endregion
    }
}

