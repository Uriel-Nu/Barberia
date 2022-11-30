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
        Turnosn NuevoTurno;
        //Turnos TurnoExistente;

        NegoTurno objNegoTurno = new NegoTurno();
        public FormBarberia()
        {
            //InitializeComponent();
            CrearDgv();
            LlenarDgv();
        //    Cargar();

        //}
        //private void Cargar()
        //{
        //    int Tgrabados = -1;
        //    NuevoTurno = new Turnos();
        //    //int.Parse(textBoxDni.Text) textBoxFecha.Text textBoxHora.Text textBoxBarbero.Text);
        //    Tgrabados = objNegoTurno.abmturnos("Alta", NuevoTurno);

        //    if (Tgrabados == -1)
        //    {
        //        MessageBox.Show("No se pudo grabar el turno en el sistema");

        //    }
        //    else
        //        MessageBox.Show(" se pudo grabar el turno en el sistema");



        }
        private void CrearDgv()
        {
            InitializeComponent();
            dgv1.Columns.Add("0", "Dni");
            dgv1.Columns.Add("1", "Fecha");
            dgv1.Columns.Add("2", "Hora");
            dgv1.Columns.Add("3", "Barbero");


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
            NuevoTurno = new Turnosn(int.Parse(textBoxDni.Text),textBoxFecha.Text,textBoxHora.Text,textBoxBarbero.Text);
            //int.Parse(textBoxDni.Text) textBoxFecha.Text textBoxHora.Text textBoxBarbero.Text);
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


