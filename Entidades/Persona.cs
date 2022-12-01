using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        //private string nombre;
        
        private int id_cliente;
        private string nombre;
        private int telefono;
        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}
        public int Id_cliente
        {
            get { return Id_cliente; }
            set { Id_cliente = value; }
        }
        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public Persona()
        { }
        public Persona(int id_cliente, string nombre, int telefono)

        {
            Id_cliente = id_cliente;
            Nombre = nombre;
            Telefono = telefono;
            
        }
    }
}
