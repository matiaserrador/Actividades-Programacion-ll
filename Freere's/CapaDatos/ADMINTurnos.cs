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
    public class ADMINTurnos : DatosConexionBDD
    {
        public int abmTurnos(string accion, Turnos objTurno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
                orden = $"insert into Turnos values ({objTurno.DNI}, '{objTurno.FECHA}',{objTurno.HORA},'{objTurno.PAGADO}', '{objTurno.BARBERO}', {objTurno.IDCLIENTE})";


            if (accion == "Modificar")
                orden = $"update Turnos set DNI =  {objTurno.DNI} where id = {objTurno.ID}; " +
                        $"update Turnos set FECHA = '{objTurno.FECHA}' where id = {objTurno.ID}; " +
                        $"update Turnos set HORA = {objTurno.HORA} where id = {objTurno.ID}; " +
                        $"update Turnos set PAGADO = '{objTurno.PAGADO}' where id = {objTurno.ID}; " +
                        $"update Turnos set BARBERO = '{objTurno.BARBERO}' where id = {objTurno.ID};" +
                        $"update Turnos set IDCLIENTE = {objTurno.IDCLIENTE} where id = {objTurno.ID};";



            if (accion == "Baja")
                orden = $"delete from Turnos where id = {objTurno.ID};";


            

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cargar, modificar o borrar {objTurno} ", e);

            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();

            }
            return resultado;

        }
        public DataSet ListadoTurnos(string cual) 
        {
            string orden = string.Empty;// se declara y se limpia la variable orden
            if (cual != "Todos")
                orden = $"select * from Turnos where id = {int.Parse(cual)};";
            else
                orden = "select * from Turnos";
            

            SqlCommand cmd = new SqlCommand(orden, conexion);//se crea el command y se instancia,llama la orden si es un inser, update o felete
            DataSet ds = new DataSet(); // se declara y se crea el dataset
            SqlDataAdapter da = new SqlDataAdapter();//se declara y crea el dataadapter
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);// se llena el dataset con el DataAdapter


            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Turnos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet ListadoTurnosBusqueda(string cual)
        {
            string orden = $"select * from Turnos  where id like '%{cual}%' or DNI like '%{cual}%' or FECHA like '%{cual}%' or HORA like '%{cual}%' or PAGADO like '%{cual}%' or BARBERO like '%{cual}%' or IDCLIENTE like '%{cual}%';";

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
                throw new Exception("Error al buscar el turno", e);
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
