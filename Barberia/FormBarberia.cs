using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;


namespace Barberia
{
    public partial class FormBarberia : Form

    {
        Turnosnuevo NuevoTurno;
        //Turnos TurnoExistente;

        NegoTurno objNegoTurno = new NegoTurno();
        public FormBarberia()
        {
            
            CrearDgv();
            LlenarDgv();
        



        }
        private void CrearDgv()
        {
            InitializeComponent();
            dgv1.Columns.Add("0", "id");
            dgv1.Columns.Add("1", "Nombre");
            dgv1.Columns.Add("2", "Fecha");
            dgv1.Columns.Add("3", "Hora");
            dgv1.Columns.Add("4", "Barbero");

        }

        private void LlenarDgv()
        {
            dgv1.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegoTurno.listadoTurnos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),
                    dgv1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
                MessageBox.Show("No hay productos cargados en el sistema");
        }






        private void Btncargar_Click(object sender, EventArgs e)
        {
            int Tgrabados = -1;
            NuevoTurno = new Turnosnuevo(textBoxNombre.Text, textBoxFecha.Text, textBoxHora.Text, textBoxBarbero.Text, int.Parse(TextBoxid.Text));
            
            Tgrabados = objNegoTurno.abmturnos("Alta", NuevoTurno);

            if (Tgrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el turno en el sistema");

            }
            else
            {




                LlenarDgv();
                //Cargar();

            }

        }

       
    }

        


    }


