using ClinicaApp.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conexion = "server=localhost;database=gestion_de_clinicas;uid=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                // Cargar pacientes
                MySqlCommand cmd = new MySqlCommand("SELECT id_paciente, nombre FROM Pacientes", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ComboItem item = new ComboItem()
                    {
                        Id = reader.GetInt32("id_paciente"),
                        Nombre = reader.GetString("nombre")
                    };
                    comboPaciente.Items.Add(item);
                }
                reader.Close();

                // Cargar médicos
                cmd = new MySqlCommand("SELECT id_medico, nombre FROM Medicos", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ComboItem item = new ComboItem()
                    {
                        Id = reader.GetInt32("id_medico"),
                        Nombre = reader.GetString("nombre")
                    };
                    comboMedico.Items.Add(item);
                }
                reader.Close();
                conn.Close();
            }
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string especialidad = txtEspecialidad.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            string conexion = "server=localhost;database=gestion_de_clinicas;uid=root;pwd=;";
            string query = "INSERT INTO Medicos (nombre, especialidad, telefono, correo) VALUES (@nombre, @especialidad, @telefono, @correo)";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@especialidad", especialidad);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Médico registrado correctamente");
        }

        private void btnRegistrarPacientes_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre1.Text;
            string genero = txtGenero.Text;
            string fecha_nacimiento = txtFecha_nacimiento.Text;
            string telefono = txtTelefono1.Text;
            string correo = txtCorreo1.Text;

            string conexion = "server=localhost;database=gestion_de_clinicas;uid=root;pwd=;";
            string query = "INSERT INTO Medicos (nombre, especialidad, telefono, correo) VALUES (@nombre, @especialidad, @telefono, @correo)";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Paciente registrado correctamente");
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            int idPaciente = ObtenerIdSeleccionado(comboPaciente);
            int idMedico = ObtenerIdSeleccionado(comboMedico);
            DateTime fecha = dateFecha.Value;
            TimeSpan hora = dateHora.Value.TimeOfDay;
            string motivo = txtMotivo.Text;

            string conexion = "server=localhost;database=gestion_de_clinicas;uid=root;pwd=;";
            string query = "INSERT INTO Citas (id_paciente, id_medico, fecha_cita, hora_cita, motivo_consulta) VALUES (@p, @m, @f, @h, @mot)";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p", idPaciente);
                cmd.Parameters.AddWithValue("@m", idMedico);
                cmd.Parameters.AddWithValue("@f", fecha);
                cmd.Parameters.AddWithValue("@h", hora);
                cmd.Parameters.AddWithValue("@mot", motivo);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cita registrada");
        }
        private int ObtenerIdSeleccionado(ComboBox combo)
        {
            dynamic item = combo.SelectedItem;
            return item.Id;
        }
    }
}
