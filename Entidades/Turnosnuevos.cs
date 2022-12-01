using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnosnuevos
    {

        
        private string fecha;
        private string hora;
        private string barbero;
        private int id;
        private int id_cliente;
        //propiedad
        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }



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
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        //constructor por defecto
        //public Turnosnuevo()
        //{ 
        //}
        //constructor con datos
        public Turnosnuevos ( int id_cliente , string fecha,string hora,string barbero,int id)

        {
            Id_cliente = id_cliente;
            Fecha = fecha;
            Hora = hora;
            Barbero = barbero;
            Id = id;    
        }
        public Turnosnuevos( int id_cliente , string fecha, string hora, string barbero)

        {
            Id_cliente= id_cliente;
            Fecha = fecha;
            Hora = hora;
            Barbero = barbero;
           
        }
    }
}
