using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barberia
{
    public partial class Cliente : Form
    {

        Persona NuevaPersona;
        NegoCliente objNegoCliente = new NegoCliente();

        public Cliente()
        {
            CrearDgv1();
            LlenarDgv1();
        }
        private void CrearDgv1()
        {
            InitializeComponent();
            dgv2.Columns.Add("0", "codigo-cliente");
            dgv2.Columns.Add("1", "nombre");
            dgv2.Columns.Add("2", "telefono");


        }
        private void LlenarDgv1()
        {
            dgv2.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegoCliente.ListadoCliente("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),
                    dgv2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay productos cargados en el sistema");
        }

        private void Btncargar_Click(object sender, EventArgs e)
        {
            int Cgrabados = -1;
            NuevaPersona = new Persona(int.Parse(textBoxCodCli.Text), textBoxNombre.Text, int.Parse(textBoxTel.Text));
           // Cgrabados = objNegoCliente.abmturnos("Alta", NuevoTurno);
            if (Cgrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el turno en el sistema");

            }
            else
            {
                LlenarDgv1();
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
