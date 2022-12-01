using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class AdministrarTurnos : DatosConexion
    {
        public int abmTurnos (string accion, Turnosnuevos objTurnosnuevo)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
                orden = $"insert into Turnosnuevos  values ( '{objTurnosnuevo.Id_cliente}', '{ objTurnosnuevo.Fecha}','{ objTurnosnuevo.Hora}','{objTurnosnuevo.Barbero}')";

            if (accion == "Modificar")
                orden = $"update Turnosnuevos set Fecha= ´{objTurnosnuevo.Fecha}' where  fecha='{objTurnosnuevo.Fecha}'";
            

           
            if (accion == "Baja")
                orden = $"delete from Turnosnuevos fecha= '{objTurnosnuevo.Fecha}'";
            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();// da un entero como resultado ya sea un -1 si no lo encuentra o el numero de fila que hizo
            }
            catch (Exception e)
            {

                throw new Exception($"Error al tratar de guardar,borrar o modificar ",e);

            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();

            }
            return  resultado;

        }
     public DataSet ListadoTurnos (string cual) // para todos los datos segun el NombreCliente
        {
            string orden = string.Empty;// se declara y se limpia la variable orden
            if (cual != "Todos")
                orden = $"select * from turnosnuevos where  = {(cual)};";
            else
                orden = "select * from turnosnuevos;";
            // falta hacer el delete

            SqlCommand cmd = new SqlCommand(orden, conexion);//se crea el command y se instancia,llama la orden si es un inser, update o felete
            DataSet ds = new DataSet(); // se declara y se crea el dataset
            SqlDataAdapter da = new SqlDataAdapter();//se declara y crea el dataadapter
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);// se llena el dataset con el DataAdapter


            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Turnosnuevos", e);
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
    

        



    

