namespace DeberInterfaces.Vistas
{
    partial class Titulo_Autores
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
            this.lst_TAtiendas = new System.Windows.Forms.ListBox();
            this.btn_TAguardar = new System.Windows.Forms.Button();
            this.btn_TAguardareditado = new System.Windows.Forms.Button();
            this.btn_TAregistrar = new System.Windows.Forms.Button();
            this.btn_TAeditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TAtitulo = new System.Windows.Forms.ComboBox();
            this.cmb_TAautor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_TAordenautor = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_TAporcentajeregalias = new System.Windows.Forms.NumericUpDown();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TAordenautor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TAporcentajeregalias)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.label8.Location = new System.Drawing.Point(256, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 29);
            this.label8.TabIndex = 94;
            this.label8.Text = "Gestión de títulos de autores";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lst_TAtiendas
            // 
            this.lst_TAtiendas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_TAtiendas.FormattingEnabled = true;
            this.lst_TAtiendas.ItemHeight = 21;
            this.lst_TAtiendas.Location = new System.Drawing.Point(476, 85);
            this.lst_TAtiendas.Name = "lst_TAtiendas";
            this.lst_TAtiendas.ScrollAlwaysVisible = true;
            this.lst_TAtiendas.Size = new System.Drawing.Size(325, 235);
            this.lst_TAtiendas.TabIndex = 117;
            // 
            // btn_TAguardar
            // 
            this.btn_TAguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TAguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_TAguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TAguardar.Location = new System.Drawing.Point(476, 373);
            this.btn_TAguardar.Name = "btn_TAguardar";
            this.btn_TAguardar.Size = new System.Drawing.Size(149, 32);
            this.btn_TAguardar.TabIndex = 116;
            this.btn_TAguardar.Text = "Eliminar";
            this.btn_TAguardar.UseVisualStyleBackColor = false;
            // 
            // btn_TAguardareditado
            // 
            this.btn_TAguardareditado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TAguardareditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_TAguardareditado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TAguardareditado.Enabled = false;
            this.btn_TAguardareditado.Location = new System.Drawing.Point(652, 373);
            this.btn_TAguardareditado.Name = "btn_TAguardareditado";
            this.btn_TAguardareditado.Size = new System.Drawing.Size(149, 32);
            this.btn_TAguardareditado.TabIndex = 115;
            this.btn_TAguardareditado.Text = "Guardar Editado";
            this.btn_TAguardareditado.UseVisualStyleBackColor = false;
            // 
            // btn_TAregistrar
            // 
            this.btn_TAregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TAregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_TAregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TAregistrar.Location = new System.Drawing.Point(476, 335);
            this.btn_TAregistrar.Name = "btn_TAregistrar";
            this.btn_TAregistrar.Size = new System.Drawing.Size(149, 32);
            this.btn_TAregistrar.TabIndex = 113;
            this.btn_TAregistrar.Text = "Registrar";
            this.btn_TAregistrar.UseVisualStyleBackColor = false;
            // 
            // btn_TAeditar
            // 
            this.btn_TAeditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TAeditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_TAeditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TAeditar.Location = new System.Drawing.Point(652, 335);
            this.btn_TAeditar.Name = "btn_TAeditar";
            this.btn_TAeditar.Size = new System.Drawing.Size(149, 32);
            this.btn_TAeditar.TabIndex = 114;
            this.btn_TAeditar.Text = "Editar";
            this.btn_TAeditar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 122;
            this.label4.Text = "Orden del autor";
            // 
            // cmb_TAtitulo
            // 
            this.cmb_TAtitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TAtitulo.FormattingEnabled = true;
            this.cmb_TAtitulo.Location = new System.Drawing.Point(243, 132);
            this.cmb_TAtitulo.Name = "cmb_TAtitulo";
            this.cmb_TAtitulo.Size = new System.Drawing.Size(178, 29);
            this.cmb_TAtitulo.TabIndex = 121;
            // 
            // cmb_TAautor
            // 
            this.cmb_TAautor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TAautor.FormattingEnabled = true;
            this.cmb_TAautor.Location = new System.Drawing.Point(243, 85);
            this.cmb_TAautor.Name = "cmb_TAautor";
            this.cmb_TAautor.Size = new System.Drawing.Size(178, 29);
            this.cmb_TAautor.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 119;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 118;
            this.label2.Text = "Título";
            // 
            // nud_TAordenautor
            // 
            this.nud_TAordenautor.Location = new System.Drawing.Point(243, 177);
            this.nud_TAordenautor.Name = "nud_TAordenautor";
            this.nud_TAordenautor.Size = new System.Drawing.Size(68, 28);
            this.nud_TAordenautor.TabIndex = 123;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.nud_TAporcentajeregalias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 422);
            this.panel1.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 125;
            this.label1.Text = "Porcentaje de regalías";
            // 
            // nud_TAporcentajeregalias
            // 
            this.nud_TAporcentajeregalias.Location = new System.Drawing.Point(243, 223);
            this.nud_TAporcentajeregalias.Name = "nud_TAporcentajeregalias";
            this.nud_TAporcentajeregalias.Size = new System.Drawing.Size(68, 28);
            this.nud_TAporcentajeregalias.TabIndex = 125;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(59, 377);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(63, 27);
            this.btn_Limpiar.TabIndex = 126;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Titulo_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(813, 422);
            this.Controls.Add(this.nud_TAordenautor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TAtitulo);
            this.Controls.Add(this.cmb_TAautor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_TAtiendas);
            this.Controls.Add(this.btn_TAguardar);
            this.Controls.Add(this.btn_TAguardareditado);
            this.Controls.Add(this.btn_TAregistrar);
            this.Controls.Add(this.btn_TAeditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Titulo_Autores";
            this.Text = "Titulo_Autores";
            ((System.ComponentModel.ISupportInitialize)(this.nud_TAordenautor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TAporcentajeregalias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lst_TAtiendas;
        private System.Windows.Forms.Button btn_TAguardar;
        private System.Windows.Forms.Button btn_TAguardareditado;
        private System.Windows.Forms.Button btn_TAregistrar;
        private System.Windows.Forms.Button btn_TAeditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TAtitulo;
        private System.Windows.Forms.ComboBox cmb_TAautor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_TAordenautor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_TAporcentajeregalias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}