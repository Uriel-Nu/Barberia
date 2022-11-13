using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//preguntar por que esta en gris
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Barberia
{
    public partial class FormBarberia : Form

    {
        Turno NuevoTurno;
        Turno TurnoExistente;

        NegoTurno objNegoTurno = new NegoTurno();
        public FormBarberia()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();

            void CrearDgv()
            {
                dgv1.Columns.Add("0", "dni");
                dgv1.Columns.Add("1", "fecha");
                dgv1.Columns.Add("2", "hora");
                dgv1.Columns.Add("3", "barbero");


            }
            void LlenarDgv()
            {
                dgv1.Rows.Clear();
                DataSet ds = new DataSet();
                ds = objNegoTurno.listadoProfesionales("Todos");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        // es el dni fecha hora barbero
                        dgv1.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                    }
                }
                else
                    MessageBox.Show("no hay turnos cargados");
            }
        }

        private void Btncargar_Click(object sender, EventArgs e)
        {
            int Tgrabados = -1;
            NuevoTurno = new Turno(int.Parse(textBoxDni.Text), textBoxFecha.Text, textBoxHora.Text, textBoxBarbero.Text);
            Tgrabados = objNegoTurno.abmTurnos("Alta", NuevoTurno);

            if (Tgrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el turno en el sistema");

            }
            else
            {
                LlenarDgv();
            }
        }

        private void Btncargar_Click_1(object sender, EventArgs e)
        {

        }
    }


}

