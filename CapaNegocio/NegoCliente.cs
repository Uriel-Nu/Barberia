using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NegoCliente
    {
      AdministrarClientes DatosObjAdmCliente = new AdministrarClientes();// declara objeto de administrarTurno
        public int abmturnos(string accion, Turno objCliente)
        {
            return DatosObjAdmCliente.abmClientes(accion, objCliente);//devuelve lo que devuelva el metodo de abmturnos
        }
        public DataSet ListadoCliente(string cual)
        {
            return DatosObjAdmCliente.ListadoClientes(cual);
        }
    }
}

