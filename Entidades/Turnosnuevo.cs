﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnosnuevo
    {

        private string nombre;
        private string fecha;
        private string hora;
        private string barbero;
        private int id;
        //propiedad
       

        
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
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //constructor por defecto
        //public Turnosnuevo()
        //{ 
        //}
        //constructor con datos
        public Turnosnuevo (string nombre, string fecha,string hora,string barbero,int id)

        {
            Nombre = nombre;
            Fecha = fecha;
            Hora = hora;
            Barbero = barbero;
            Id = id;    
        }
        public Turnosnuevo(string nombre, string fecha, string hora, string barbero)

        {
            Nombre = nombre;
            Fecha = fecha;
            Hora = hora;
            Barbero = barbero;
           
        }
    }
}
