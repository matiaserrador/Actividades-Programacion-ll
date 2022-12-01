using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class ADMINClientes : DatosConexionBDD
    {
        public int abmClientes(string accion, Clientes objClientes)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Clientes values ({objClientes.CodCliente},'{objClientes.NOMBRE}')";


            if (accion == "Modificar")
                orden = $"UPDATE Clientes SET CodCliente= {objClientes.CodCliente}, NOMBRE='{objClientes.NOMBRE}' WHERE id={objClientes.ID}; ";


            if (accion == "Baja")
                orden = $"delete from Clientes where id = {objClientes.ID};";




            SqlCommand cmd = new SqlCommand (orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar {objClientes}",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        public DataSet ListadoClientes(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = $"select * from Clientes where id =  {int.Parse(cual)};";
            else
                orden = "select * from Clientes;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Clientes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet ListadoClientesBusqueda(string cual)
        {
            string orden = $"select * from Clientes where id like '%{cual}%' or CodCliente like '%{cual}%' or NOMBRE like '%{cual}%';";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar al Cliente", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
  