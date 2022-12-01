using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using CapaDatos;


// se comunica la capa de presentacion con la capa de datos
namespace CapaNegocio
{
    public class NegoTurno
    {
        AdministrarTurnos DatosObjAdminTurno = new AdministrarTurnos();// declara objeto de administrarTurno
        public int abmturnos(string accion, Turnosnuevos objturno)
        {
            return DatosObjAdminTurno.abmTurnos(accion, objturno);//devuelve lo que devuelva el metodo de abmturnos
        }
        public DataSet listadoTurnos(string cual)
        {
            return DatosObjAdminTurno.ListadoTurnos(cual);
        }
    }
}

