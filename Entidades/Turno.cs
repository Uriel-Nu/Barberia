using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private string NombreCliente;
        private DateTime fecha;
        private DateTime hora;
        private String barbero;

        public string pNombreCliente
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public String Barbero
        {
            get { return barbero; }
            set { barbero = value; }
        }

    }
}
