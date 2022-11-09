using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cliente
    {
        private string nombre;
        private long dni;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public Cliente()
        { }

    }
}
