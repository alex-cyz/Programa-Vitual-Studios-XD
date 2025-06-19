namespace DeberInterfaces.Vistas
{
    partial class Trabajos
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
            this.lst_Tlista = new System.Windows.Forms.ListBox();
            this.btn_Tguardar = new System.Windows.Forms.Button();
            this.btn_Tguardareditado = new System.Windows.Forms.Button();
            this.btn_Teditar = new System.Windows.Forms.Button();
            this.btn_Tregistrar = new System.Windows.Forms.Button();
            this.txt_Tmaxima = new System.Windows.Forms.TextBox();
            this.txt_Tminima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tdescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.lst_Tlista);
            this.panel1.Controls.Add(this.btn_Tguardar);
            this.panel1.Controls.Add(this.btn_Tguardareditado);
            this.panel1.Controls.Add(this.btn_Teditar);
            this.panel1.Controls.Add(this.btn_Tregistrar);
            this.panel1.Controls.Add(this.txt_Tmaxima);
            this.panel1.Controls.Add(this.txt_Tminima);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Tdescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 433);
            this.panel1.TabIndex = 0;
            // 
            // lst_Tlista
            // 
            this.lst_Tlista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_Tlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_Tlista.FormattingEnabled = true;
            this.lst_Tlista.ItemHeight = 21;
            this.lst_Tlista.Location = new System.Drawing.Point(497, 69);
            this.lst_Tlista.Name = "lst_Tlista";
            this.lst_Tlista.ScrollAlwaysVisible = true;
            this.lst_Tlista.Size = new System.Drawing.Size(325, 256);
            this.lst_Tlista.TabIndex = 70;
            // 
            // btn_Tguardar
            // 
            this.btn_Tguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Tguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tguardar.Location = new System.Drawing.Point(497, 385);
            this.btn_Tguardar.Name = "btn_Tguardar";
            this.btn_Tguardar.Size = new System.Drawing.Size(149, 32);
            this.btn_Tguardar.TabIndex = 69;
            this.btn_Tguardar.Text = "Eliminar";
            this.btn_Tguardar.UseVisualStyleBackColor = false;
            // 
            // btn_Tguardareditado
            // 
            this.btn_Tguardareditado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tguardareditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Tguardareditado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tguardareditado.Enabled = false;
            this.btn_Tguardareditado.Location = new System.Drawing.Point(673, 385);
            this.btn_Tguardareditado.Name = "btn_Tguardareditado";
            this.btn_Tguardareditado.Size = new System.Drawing.Size(149, 32);
            this.btn_Tguardareditado.TabIndex = 68;
            this.btn_Tguardareditado.Text = "Guardar Editado";
            this.btn_Tguardareditado.UseVisualStyleBackColor = false;
            // 
            // btn_Teditar
            // 
            this.btn_Teditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Teditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Teditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Teditar.Location = new System.Drawing.Point(673, 347);
            this.btn_Teditar.Name = "btn_Teditar";
            this.btn_Teditar.Size = new System.Drawing.Size(149, 32);
            this.btn_Teditar.TabIndex = 67;
            this.btn_Teditar.Text = "Editar";
            this.btn_Teditar.UseVisualStyleBackColor = false;
            // 
            // btn_Tregistrar
            // 
            this.btn_Tregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Tregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tregistrar.Location = new System.Drawing.Point(497, 347);
            this.btn_Tregistrar.Name = "btn_Tregistrar";
            this.btn_Tregistrar.Size = new System.Drawing.Size(149, 32);
            this.btn_Tregistrar.TabIndex = 66;
            this.btn_Tregistrar.Text = "Registrar";
            this.btn_Tregistrar.UseVisualStyleBackColor = false;
            // 
            // txt_Tmaxima
            // 
            this.txt_Tmaxima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Tmaxima.Location = new System.Drawing.Point(124, 156);
            this.txt_Tmaxima.MaxLength = 10;
            this.txt_Tmaxima.Name = "txt_Tmaxima";
            this.txt_Tmaxima.Size = new System.Drawing.Size(183, 28);
            this.txt_Tmaxima.TabIndex = 65;
            // 
            // txt_Tminima
            // 
            this.txt_Tminima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Tminima.Location = new System.Drawing.Point(126, 115);
            this.txt_Tminima.MaxLength = 10;
            this.txt_Tminima.Name = "txt_Tminima";
            this.txt_Tminima.Size = new System.Drawing.Size(183, 28);
            this.txt_Tminima.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Paga máxima";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Paga mínima";
            // 
            // txt_Tdescripcion
            // 
            this.txt_Tdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Tdescripcion.Location = new System.Drawing.Point(124, 69);
            this.txt_Tdescripcion.MaxLength = 50;
            this.txt_Tdescripcion.Name = "txt_Tdescripcion";
            this.txt_Tdescripcion.Size = new System.Drawing.Size(349, 28);
            this.txt_Tdescripcion.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.label8.Location = new System.Drawing.Point(318, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Gestión de trabajos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(16, 390);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(63, 27);
            this.btn_Limpiar.TabIndex = 71;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Trabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(834, 433);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Trabajos";
            this.Text = "Trabajos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tmaxima;
        private System.Windows.Forms.TextBox txt_Tminima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Tlista;
        private System.Windows.Forms.Button btn_Tguardar;
        private System.Windows.Forms.Button btn_Tguardareditado;
        private System.Windows.Forms.Button btn_Teditar;
        private System.Windows.Forms.Button btn_Tregistrar;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}