namespace DeberInterfaces.Vistas
{
    partial class Ventas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_Efechacontratacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_Vorden = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Atrabajo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Vcantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Vguardar = new System.Windows.Forms.Button();
            this.btn_Vguardareditado = new System.Windows.Forms.Button();
            this.btn_Vregistrar = new System.Windows.Forms.Button();
            this.btn_Veditar = new System.Windows.Forms.Button();
            this.lst_Vventas = new System.Windows.Forms.ListBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.lst_Vventas);
            this.panel1.Controls.Add(this.btn_Vguardar);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.btn_Vguardareditado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Vregistrar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btn_Veditar);
            this.panel1.Controls.Add(this.nud_Vcantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_Efechacontratacion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nud_Vorden);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_Atrabajo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 430);
            this.panel1.TabIndex = 0;
            // 
            // dtp_Efechacontratacion
            // 
            this.dtp_Efechacontratacion.Location = new System.Drawing.Point(195, 187);
            this.dtp_Efechacontratacion.Name = "dtp_Efechacontratacion";
            this.dtp_Efechacontratacion.Size = new System.Drawing.Size(205, 28);
            this.dtp_Efechacontratacion.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 99;
            this.label9.Text = "Fecha de Orden";
            // 
            // nud_Vorden
            // 
            this.nud_Vorden.Location = new System.Drawing.Point(145, 139);
            this.nud_Vorden.Name = "nud_Vorden";
            this.nud_Vorden.Size = new System.Drawing.Size(87, 28);
            this.nud_Vorden.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "No. Orden";
            // 
            // cmb_Atrabajo
            // 
            this.cmb_Atrabajo.FormattingEnabled = true;
            this.cmb_Atrabajo.Location = new System.Drawing.Point(145, 87);
            this.cmb_Atrabajo.Name = "cmb_Atrabajo";
            this.cmb_Atrabajo.Size = new System.Drawing.Size(255, 29);
            this.cmb_Atrabajo.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 95;
            this.label7.Text = "Tienda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.label8.Location = new System.Drawing.Point(300, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 29);
            this.label8.TabIndex = 94;
            this.label8.Text = "Gestión de ventas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Título vendido";
            // 
            // nud_Vcantidad
            // 
            this.nud_Vcantidad.Location = new System.Drawing.Point(145, 272);
            this.nud_Vcantidad.Name = "nud_Vcantidad";
            this.nud_Vcantidad.Size = new System.Drawing.Size(87, 28);
            this.nud_Vcantidad.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Cantidad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 29);
            this.comboBox1.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 105;
            this.label4.Text = "Términos de pago";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(197, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 29);
            this.comboBox2.TabIndex = 106;
            // 
            // btn_Vguardar
            // 
            this.btn_Vguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Vguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Vguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vguardar.Location = new System.Drawing.Point(458, 385);
            this.btn_Vguardar.Name = "btn_Vguardar";
            this.btn_Vguardar.Size = new System.Drawing.Size(149, 32);
            this.btn_Vguardar.TabIndex = 92;
            this.btn_Vguardar.Text = "Eliminar";
            this.btn_Vguardar.UseVisualStyleBackColor = false;
            // 
            // btn_Vguardareditado
            // 
            this.btn_Vguardareditado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Vguardareditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Vguardareditado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vguardareditado.Enabled = false;
            this.btn_Vguardareditado.Location = new System.Drawing.Point(634, 385);
            this.btn_Vguardareditado.Name = "btn_Vguardareditado";
            this.btn_Vguardareditado.Size = new System.Drawing.Size(149, 32);
            this.btn_Vguardareditado.TabIndex = 91;
            this.btn_Vguardareditado.Text = "Guardar Editado";
            this.btn_Vguardareditado.UseVisualStyleBackColor = false;
            // 
            // btn_Vregistrar
            // 
            this.btn_Vregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Vregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Vregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vregistrar.Location = new System.Drawing.Point(458, 347);
            this.btn_Vregistrar.Name = "btn_Vregistrar";
            this.btn_Vregistrar.Size = new System.Drawing.Size(149, 32);
            this.btn_Vregistrar.TabIndex = 89;
            this.btn_Vregistrar.Text = "Registrar";
            this.btn_Vregistrar.UseVisualStyleBackColor = false;
            // 
            // btn_Veditar
            // 
            this.btn_Veditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Veditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Veditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Veditar.Location = new System.Drawing.Point(634, 347);
            this.btn_Veditar.Name = "btn_Veditar";
            this.btn_Veditar.Size = new System.Drawing.Size(149, 32);
            this.btn_Veditar.TabIndex = 90;
            this.btn_Veditar.Text = "Editar";
            this.btn_Veditar.UseVisualStyleBackColor = false;
            // 
            // lst_Vventas
            // 
            this.lst_Vventas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_Vventas.FormattingEnabled = true;
            this.lst_Vventas.ItemHeight = 21;
            this.lst_Vventas.Location = new System.Drawing.Point(465, 87);
            this.lst_Vventas.Name = "lst_Vventas";
            this.lst_Vventas.ScrollAlwaysVisible = true;
            this.lst_Vventas.Size = new System.Drawing.Size(318, 235);
            this.lst_Vventas.TabIndex = 107;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(57, 390);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(63, 27);
            this.btn_Limpiar.TabIndex = 108;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(810, 430);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vcantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Atrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_Vorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Efechacontratacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_Vcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Vguardar;
        private System.Windows.Forms.Button btn_Vguardareditado;
        private System.Windows.Forms.Button btn_Vregistrar;
        private System.Windows.Forms.Button btn_Veditar;
        private System.Windows.Forms.ListBox lst_Vventas;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}