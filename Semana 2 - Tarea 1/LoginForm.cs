using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_2___Tarea_1
{
    public partial class LoginForm : Form
    {
        private int intentosRestantes = 3;

        private const string USUARIO = "admin";
        private const string CLAVE = "1234";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string clave = textBoxClave.Text;

            if (usuario == USUARIO && clave == CLAVE)
            {
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                intentosRestantes--;
                MessageBox.Show($"Credenciales incorrectas. Intentos restantes: {intentosRestantes}");

                if (intentosRestantes == 0)
                {
                    MessageBox.Show("Has superado el número de intentos. El programa se cerrará.");
                    Application.Exit();
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ad(object sender, EventArgs e)
        {

        }
    }
}
