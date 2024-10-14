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

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class IngresarDniForm : Form
    {
        public string DniIngresado { get; set; } = string.Empty;

        public string Dni
        {
            get { return txtDNI.Text; }
        }

        public IngresarDniForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            // Obtener la conexión desde la clase Conexion
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Clientes WHERE DNI = @DNI", connection);
                command.Parameters.AddWithValue("@DNI", dni);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // El DNI ya existe, mostrar un mensaje
                        MessageBox.Show("El DNI ya está registrado en la base de datos.");
                    }
                    else
                    {
                        // El DNI no existe, abrir el formulario para ingresar otros datos
                        IngresarClienteForm ingresarClienteForm = new IngresarClienteForm(dni);
                        ingresarClienteForm.Owner = this.Owner; // Establece el dueño para que aparezca correctamente
                        ingresarClienteForm.ShowDialog(); // Cambiar a ShowDialog() para que sea modal
                        this.Close();
                    }
                }
            }
        }
    }
}