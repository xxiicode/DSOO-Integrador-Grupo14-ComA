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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Método para el evento Click del botón Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        // Método para el evento Click del botón Agregar Cliente
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
                IngresarDniForm formDni = new IngresarDniForm();
            if (formDni.ShowDialog() == DialogResult.OK)
            {
                string dniIngresado = formDni.Dni;
                VerificarCliente(dniIngresado);
            }
        }

        // Método para el evento Click del botón Ver Clientes
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Ver Clientes"
            MessageBox.Show("Ver Clientes clickeado");
        }

        // Método para el evento Click del botón Cobrar Cliente
        private void btnCobrarCliente_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Cobrar Cliente"
            MessageBox.Show("Cobrar Cliente clickeado");
        }

        // Método para el evento Click del botón Mostrar Clientes que vencen hoy
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Mostrar Clientes que vencen hoy"
            MessageBox.Show("Clientes que vencen hoy clickeado");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void VerificarCliente(string dni)
        {
            DataTable tablaCliente = new DataTable();
            using (MySqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes WHERE DNI = @dni", sqlCon);
                comando.Parameters.AddWithValue("@dni", dni);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tablaCliente);
            }

            if (tablaCliente.Rows.Count > 0)
            {
                MessageBox.Show("El cliente ya existe en la base de datos");
            }
            else
            {
                //aca abre el formulario IngresarClienteForm con el DNI ingresado
                IngresarClienteForm formCliente = new IngresarClienteForm(dni);
                formCliente.Owner = this; // Establece el formulario Principal como dueño
                formCliente.ShowDialog(); // Muestra el formulario como diálogo
            }
        }

    }
}