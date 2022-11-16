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
using CapaNegocio;


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
                    dgv1.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                MessageBox.Show("No hay productos cargados en el sistema");
        }
        private void CrearDgv()
        {
            InitializeComponent();
            dgv1.Columns.Add("0", "dni");
            dgv1.Columns.Add("1", "fecha");
            dgv1.Columns.Add("2", "hora");
            dgv1.Columns.Add("3", "barbero");


        }



        private void Btncargar_Click(object sender, EventArgs e)
        {
            int Tgrabados = -1;
            NuevoTurno = new Turno(int.Parse(textBoxDni.Text), textBoxFecha.Text, textBoxHora.Text, textBoxBarbero.Text);
            Tgrabados = objNegoTurno.abmturnos("Alta", NuevoTurno);

            if (Tgrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el turno en el sistema");

            }
            else
            {
                //    lblCodigoMov.Text = NuevoProducto.p_codigo.ToString();
                //    lblDescripMov.Text = NuevoProducto.p_descripcion;
                //    lbl_StockMov.Text = "Hay " + NuevoProducto.p_stock.ToString() + " Unidades";


                //    txtCantidad.Clear();
                //    txtCantidad.Focus();

                //    nuevo = true;
                   LlenarDgv();
                //}
            }


        }


    }
}

