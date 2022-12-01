using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Entidades;

namespace CapaDatos
{
    public class AdministrarClientes : DatosConexion
    {
        public int abmClientes(string accion, Turnosnuevo objcliente)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
                orden = "insert into Cliente values (" + objcliente.Nombre+ "');";

            if (accion == "Modificar")
                orden = "update Cliente set Fecha='" + objcliente.Nombre + "');"; //"'
            //where CodProf = "+ objProfesional.CodProf + "; ";

            // falta el de baja

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();// da un entero como resultado ya sea un -1 si no lo encuentra o el numero de fila que hizo
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cargar, modificar o borrar el Cliente", e);

            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();

            }
            return resultado;

        }
        public DataSet ListadoClientes(string cual) // para todos los datos segun el NombreCliente
        {
            string orden = string.Empty;// se declara y se limpia la variable orden
            if (cual != "Todos")
                orden = "select * from turnos where Dni=" + (cual) + ";";
            else
                orden = "select * from clientes";
            // falta hacer el delete

            SqlCommand cmd = new SqlCommand(orden, conexion);//se crea el command y se instancia,llama la orden si es un inser, update o felete
            DataSet ds = new DataSet(); // se declara y se crea el dataset
            SqlDataAdapter da = new SqlDataAdapter();//se declara y crea el dataadapter
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);// se llena el dataset con el tataAdapter


            }
            catch (Exception e)
            {
                throw new Exception("Error al listar clientes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;//devuelve el dataset que se lleno en la fila 69

        }



    }
}
    

    

