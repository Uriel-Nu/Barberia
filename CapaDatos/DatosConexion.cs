using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace CapaDatos
{
   public class DatosConexion
    {
        protected SqlConnection conexion;
        // protected string cadenaConexion = @"(LocalDB)\MSSQLLocalDB;Integrated Security = True; Connect Timeout = 30";
        public string cadenaConexion = "Data Source=DESKTOP-2NT6HAM\\SQLEXPRESS;Initial Catalog=the_brothers;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

        public DatosConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
