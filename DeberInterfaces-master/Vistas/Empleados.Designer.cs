namespace DeberInterfaces.Vistas
{
    partial class Empleados
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dtp_Efechacontratacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Atrabajo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Eeditorial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_Enumeropuesto = new System.Windows.Forms.NumericUpDown();
            this.lst_Elista = new System.Windows.Forms.ListBox();
            this.btn_Eguardar = new System.Windows.Forms.Button();
            this.btn_Eguardareditado = new System.Windows.Forms.Button();
            this.btn_Eeditar = new System.Windows.Forms.Button();
            this.btn_Eregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Einicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Eapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Enombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Enumeropuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.label8.Location = new System.Drawing.Point(322, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 34);
            this.label8.TabIndex = 38;
            this.label8.Text = "Gestión de empleados";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.dtp_Efechacontratacion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmb_Atrabajo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_Eeditorial);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nud_Enumeropuesto);
            this.panel1.Controls.Add(this.lst_Elista);
            this.panel1.Controls.Add(this.btn_Eguardar);
            this.panel1.Controls.Add(this.btn_Eguardareditado);
            this.panel1.Controls.Add(this.btn_Eeditar);
            this.panel1.Controls.Add(this.btn_Eregistrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Einicial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Eapellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Enombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 450);
            this.panel1.TabIndex = 39;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(39, 394);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(63, 27);
            this.btn_Limpiar.TabIndex = 60;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // dtp_Efechacontratacion
            // 
            this.dtp_Efechacontratacion.Location = new System.Drawing.Point(235, 289);
            this.dtp_Efechacontratacion.Name = "dtp_Efechacontratacion";
            this.dtp_Efechacontratacion.Size = new System.Drawing.Size(205, 33);
            this.dtp_Efechacontratacion.TabIndex = 59;
            this.dtp_Efechacontratacion.ValueChanged += new System.EventHandler(this.dtp_Efechacontratacion_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Fecha de contratación";
            // 
            // cmb_Atrabajo
            // 
            this.cmb_Atrabajo.FormattingEnabled = true;
            this.cmb_Atrabajo.Location = new System.Drawing.Point(135, 194);
            this.cmb_Atrabajo.Name = "cmb_Atrabajo";
            this.cmb_Atrabajo.Size = new System.Drawing.Size(203, 33);
            this.cmb_Atrabajo.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Trabajo";
            // 
            // cmb_Eeditorial
            // 
            this.cmb_Eeditorial.FormattingEnabled = true;
            this.cmb_Eeditorial.Location = new System.Drawing.Point(135, 241);
            this.cmb_Eeditorial.Name = "cmb_Eeditorial";
            this.cmb_Eeditorial.Size = new System.Drawing.Size(203, 33);
            this.cmb_Eeditorial.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "No. Puesto";
            // 
            // nud_Enumeropuesto
            // 
            this.nud_Enumeropuesto.Location = new System.Drawing.Point(337, 148);
            this.nud_Enumeropuesto.Name = "nud_Enumeropuesto";
            this.nud_Enumeropuesto.Size = new System.Drawing.Size(68, 33);
            this.nud_Enumeropuesto.TabIndex = 52;
            // 
            // lst_Elista
            // 
            this.lst_Elista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_Elista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_Elista.FormattingEnabled = true;
            this.lst_Elista.ItemHeight = 25;
            this.lst_Elista.Location = new System.Drawing.Point(510, 73);
            this.lst_Elista.Name = "lst_Elista";
            this.lst_Elista.ScrollAlwaysVisible = true;
            this.lst_Elista.Size = new System.Drawing.Size(325, 254);
            this.lst_Elista.TabIndex = 49;
            // 
            // btn_Eguardar
            // 
            this.btn_Eguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Eguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eguardar.Location = new System.Drawing.Point(510, 389);
            this.btn_Eguardar.Name = "btn_Eguardar";
            this.btn_Eguardar.Size = new System.Drawing.Size(149, 32);
            this.btn_Eguardar.TabIndex = 48;
            this.btn_Eguardar.Text = "Eliminar";
            this.btn_Eguardar.UseVisualStyleBackColor = false;
            // 
            // btn_Eguardareditado
            // 
            this.btn_Eguardareditado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eguardareditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Eguardareditado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eguardareditado.Enabled = false;
            this.btn_Eguardareditado.Location = new System.Drawing.Point(686, 389);
            this.btn_Eguardareditado.Name = "btn_Eguardareditado";
            this.btn_Eguardareditado.Size = new System.Drawing.Size(149, 32);
            this.btn_Eguardareditado.TabIndex = 47;
            this.btn_Eguardareditado.Text = "Guardar Editado";
            this.btn_Eguardareditado.UseVisualStyleBackColor = false;
            // 
            // btn_Eeditar
            // 
            this.btn_Eeditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eeditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Eeditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eeditar.Location = new System.Drawing.Point(686, 351);
            this.btn_Eeditar.Name = "btn_Eeditar";
            this.btn_Eeditar.Size = new System.Drawing.Size(149, 32);
            this.btn_Eeditar.TabIndex = 46;
            this.btn_Eeditar.Text = "Editar";
            this.btn_Eeditar.UseVisualStyleBackColor = false;
            // 
            // btn_Eregistrar
            // 
            this.btn_Eregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Eregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eregistrar.Location = new System.Drawing.Point(510, 351);
            this.btn_Eregistrar.Name = "btn_Eregistrar";
            this.btn_Eregistrar.Size = new System.Drawing.Size(149, 32);
            this.btn_Eregistrar.TabIndex = 45;
            this.btn_Eregistrar.Text = "Registrar";
            this.btn_Eregistrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Inicial";
            // 
            // txt_Einicial
            // 
            this.txt_Einicial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Einicial.Location = new System.Drawing.Point(135, 145);
            this.txt_Einicial.MaxLength = 1;
            this.txt_Einicial.Name = "txt_Einicial";
            this.txt_Einicial.Size = new System.Drawing.Size(36, 33);
            this.txt_Einicial.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido";
            // 
            // txt_Eapellido
            // 
            this.txt_Eapellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Eapellido.Location = new System.Drawing.Point(135, 105);
            this.txt_Eapellido.MaxLength = 30;
            this.txt_Eapellido.Name = "txt_Eapellido";
            this.txt_Eapellido.Size = new System.Drawing.Size(349, 33);
            this.txt_Eapellido.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // txt_Enombre
            // 
            this.txt_Enombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Enombre.Location = new System.Drawing.Point(135, 71);
            this.txt_Enombre.MaxLength = 20;
            this.txt_Enombre.Name = "txt_Enombre";
            this.txt_Enombre.Size = new System.Drawing.Size(349, 33);
            this.txt_Enombre.TabIndex = 39;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Enumeropuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lst_Elista;
        private System.Windows.Forms.Button btn_Eguardar;
        private System.Windows.Forms.Button btn_Eguardareditado;
        private System.Windows.Forms.Button btn_Eeditar;
        private System.Windows.Forms.Button btn_Eregistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Einicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Eapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Enombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_Enumeropuesto;
        private System.Windows.Forms.ComboBox cmb_Atrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Eeditorial;
        private System.Windows.Forms.DateTimePicker dtp_Efechacontratacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}