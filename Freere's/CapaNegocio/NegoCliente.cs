using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using Datos;
using Entidades;
using CapaDatos;

namespace CapaNegocio
{
    public class NegoCliente : ADMINClientes
    {
        ADMINClientes DatosObjAdmClientes = new ADMINClientes();// declara objeto de administrarcLIENTES
        public int abmClientes(string accion, Clientes objCliente)
        {
            return DatosObjAdmClientes.abmClientes(accion, objCliente);//devuelve lo que devuelva el metodo de abmturnos
        }
        public DataSet ListadoCliente(string cual)
        {
            return DatosObjAdmClientes.ListadoClientes(cual);
        }
        public DataSet ListadoClientesBusqueda(string cual)
        {
            return DatosObjAdmClientes.ListadoClientesBusqueda(cual);
        }
    }
}
