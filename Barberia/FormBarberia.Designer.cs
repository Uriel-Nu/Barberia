using System.Windows.Forms;

namespace Barberia
{
   public partial class FormBarberia : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soliTurn = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.lblBarbero = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxBarbero = new System.Windows.Forms.TextBox();
            this.Btncargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.TextBoxid = new System.Windows.Forms.TextBox();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.textoxid_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // soliTurn
            // 
            this.soliTurn.AutoSize = true;
            this.soliTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soliTurn.Location = new System.Drawing.Point(179, 32);
            this.soliTurn.Name = "soliTurn";
            this.soliTurn.Size = new System.Drawing.Size(187, 25);
            this.soliTurn.TabIndex = 0;
            this.soliTurn.Text = "solicitud de turnos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(60, 145);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(60, 189);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(44, 20);
            this.LblHora.TabIndex = 3;
            this.LblHora.Text = "Hora";
            // 
            // lblBarbero
            // 
            this.lblBarbero.AutoSize = true;
            this.lblBarbero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarbero.Location = new System.Drawing.Point(60, 231);
            this.lblBarbero.Name = "lblBarbero";
            this.lblBarbero.Size = new System.Drawing.Size(66, 20);
            this.lblBarbero.TabIndex = 4;
            this.lblBarbero.Text = "Barbero";
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(205, 183);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 26);
            this.textBoxHora.TabIndex = 7;
            // 
            // textBoxBarbero
            // 
            this.textBoxBarbero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarbero.Location = new System.Drawing.Point(205, 225);
            this.textBoxBarbero.Name = "textBoxBarbero";
            this.textBoxBarbero.Size = new System.Drawing.Size(100, 26);
            this.textBoxBarbero.TabIndex = 8;
            // 
            // Btncargar
            // 
            this.Btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncargar.Location = new System.Drawing.Point(421, 104);
            this.Btncargar.Name = "Btncargar";
            this.Btncargar.Size = new System.Drawing.Size(75, 33);
            this.Btncargar.TabIndex = 9;
            this.Btncargar.Text = "cargar";
            this.Btncargar.UseVisualStyleBackColor = true;
            this.Btncargar.Click += new System.EventHandler(this.Btncargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(421, 169);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 28);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(421, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(205, 323);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(343, 150);
            this.dgv1.TabIndex = 12;
            // 
            // TextBoxid
            // 
            this.TextBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxid.Location = new System.Drawing.Point(205, 104);
            this.TextBoxid.Name = "TextBoxid";
            this.TextBoxid.Size = new System.Drawing.Size(100, 26);
            this.TextBoxid.TabIndex = 15;
            this.TextBoxid.Visible = false;
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.Enabled = false;
            this.lblid_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_cliente.Location = new System.Drawing.Point(60, 274);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(111, 20);
            this.lblid_cliente.TabIndex = 16;
            this.lblid_cliente.Text = "codigo_cliente";
            // 
            // textoxid_cliente
            // 
            this.textoxid_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoxid_cliente.Location = new System.Drawing.Point(205, 274);
            this.textoxid_cliente.Name = "textoxid_cliente";
            this.textoxid_cliente.Size = new System.Drawing.Size(100, 26);
            this.textoxid_cliente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "id";
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FormBarberia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoxid_cliente);
            this.Controls.Add(this.lblid_cliente);
            this.Controls.Add(this.TextBoxid);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Btncargar);
            this.Controls.Add(this.textBoxBarbero);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.lblBarbero);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.soliTurn);
            this.Name = "FormBarberia";
            this.Text = "FormBarberia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soliTurn;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label lblBarbero;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxBarbero;
        private System.Windows.Forms.Button Btncargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgv1;
        private TextBox TextBoxid;
        private Label lblid_cliente;
        private TextBox textoxid_cliente;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}