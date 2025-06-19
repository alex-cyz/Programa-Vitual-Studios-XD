using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Semana_2___Tarea_1
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private string rutaArchivo = "usuarios.csv";

        public Form1()
        {
            InitializeComponent();
            CargarUsuariosDesdeArchivo();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string edadTexto = textBoxEdad.Text.Trim();
            string cedula = textBoxCedula.Text.Trim();
            string celular = textBoxCelular.Text.Trim();
            string correo = textBoxCorreo.Text.Trim();

            if (!int.TryParse(edadTexto, out int edad))
            {
                MessageBox.Show("Edad inválida.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cedula) ||
                string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia");
                return;
            }

            Usuario nuevoUsuario = new Usuario(nombre, edad, cedula, celular, correo);
            usuarios.Add(nuevoUsuario);
            listBoxUsuarios.Items.Add(nuevoUsuario);
            GuardarUsuariosEnArchivo();

            LimpiarCampos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedIndex != -1)
            {
                int indice = listBoxUsuarios.SelectedIndex;
                usuarios.RemoveAt(indice);
                listBoxUsuarios.Items.RemoveAt(indice);
                GuardarUsuariosEnArchivo();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Advertencia");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarUsuariosDesdeArchivo()
        {
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Usuario usuario = Usuario.FromCsv(linea);
                        usuarios.Add(usuario);
                        listBoxUsuarios.Items.Add(usuario);
                    }
                }
            }
        }

        private void GuardarUsuariosEnArchivo()
        {
            List<string> lineas = new List<string>();
            foreach (var usuario in usuarios)
            {
                lineas.Add(usuario.ToCsv());
            }
            File.WriteAllLines(rutaArchivo, lineas);
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxEdad.Clear();
            textBoxCedula.Clear();
            textBoxCelular.Clear();
            textBoxCorreo.Clear();
            textBoxNombre.Focus();
        }
    }
}
