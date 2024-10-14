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
    public partial class IngresarClienteForm : Form
    {
        public string DniIngresado { get; set; }

        // Constructor que acepta el DNI como argumento
        public IngresarClienteForm(string dni)
        {
            InitializeComponent();
            txtDNI.Text = dni; // Asigna el DNI a la propiedad
        }

        private void IngresarClienteForm_Load(object sender, EventArgs e)
        {
            txtDNI.Text = DniIngresado;
        }

    private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Suponiendo que tienes campos de texto para nombre, dirección, etc.
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string dni = DniIngresado; // Obtén el DNI ingresado desde el formulario anterior

            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                string query = "INSERT INTO Clientes (DNI, Nombre, Direccion, Telefono) VALUES (@DNI, @Nombre, @Direccion, @Telefono)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado exitosamente.");
                        this.Close(); // Cerrar el formulario después de guardar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el cliente: " + ex.Message);
                    }
                }
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica para limpiar los campos del formulario
        }
    }
}
