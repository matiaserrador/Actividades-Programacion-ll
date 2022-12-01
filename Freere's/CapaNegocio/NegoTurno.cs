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
    public class NegoTurno : ADMINTurnos
    {
        ADMINTurnos DatosObjAdmTurnos = new ADMINTurnos();// declara objeto de administrarTurno
        public int abmTurnos(string accion, Turnos objTurno)
        {
            return DatosObjAdmTurnos.abmTurnos(accion, objTurno);//devuelve lo que devuelva el metodo de abmturnos
        }
        public DataSet ListadoTurno(string cual)
        {
            return DatosObjAdmTurnos.ListadoTurnos(cual);
        }
        public DataSet ListadoTurnosBusqueda(string cual)
        {
            return DatosObjAdmTurnos.ListadoTurnosBusqueda(cual);
        }
    }
}

