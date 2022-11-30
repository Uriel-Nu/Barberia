using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnosn
    {
        private int dni;
        //private string NombreCliente;
        private string fecha;
        private string hora;
        private string barbero;
        //propiedad
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        //public string pNombreCliente
        //{
        //    get { return NombreCliente; }
        //    set { NombreCliente = value; }
        //}

        //propíedad
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        //propiedad
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        //propiedad
        public string Barbero
        {
            get { return barbero; }
            set { barbero = value; }
        }
        //constructor por defecto
        public Turnosn()
        { 
        }
        //constructor con datos
        public Turnosn ( int dni,string fecha,string hora,string barbero )

        {
            Dni = dni;
            Fecha = fecha;
            Hora = hora;
            Barbero = barbero;
        }
    }
}
