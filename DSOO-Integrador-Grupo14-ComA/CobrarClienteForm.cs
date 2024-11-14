using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class CobrarClienteForm : Form
    {
        private string dniCliente;
        private string montoCliente = "1000";
        private bool esSocio; // Indica si el cliente es socio o no

        public CobrarClienteForm(string dni)
        {
            InitializeComponent();
            this.dniCliente = dni;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            var cliente = Cliente.ObtenerClientePorDni(dniCliente);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDNI.Text = cliente.Dni;

                // Configurar referencia y monto según el tipo de cliente
                if (cliente.Tipo == "socio")
                {
                    esSocio = true;
                    txtReferencia.Text = "Cuota Socio";
                    txtMonto.Text = montoCliente; // Monto fijo para socios
                    txtReferencia.ReadOnly = true;
                    txtMonto.ReadOnly = true;
                }
                else
                {
                    esSocio = false;
                    txtReferencia.Text = "";
                    txtMonto.Text = ""; 
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos del cliente.");
                this.Close();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            // Validar que el monto no esté vacío si el cliente no es socio
            if (!esSocio && string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor, ingrese un monto válido para el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtReferencia.Text))
            {
                MessageBox.Show("Por favor, ingrese referencia de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("El monto ingresado no es válido. Por favor ingrese un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Pago procesado para {txtNombre.Text} {txtApellido.Text}.\nMonto: ${txtMonto.Text}");

            // Guardar el pago en la base de datos
            GuardarPagoEnBaseDeDatos(dniCliente, txtReferencia.Text, monto);

            // Mostrar el recibo
            ReciboForm reciboForm = new ReciboForm(txtNombre.Text, txtApellido.Text, dniCliente, esSocio ? "socio" : "no-socio", txtReferencia.Text, monto);
            reciboForm.ShowDialog();
            this.Close(); // Cierra el formulario despues de mostrar el recibo
        }

        private void GuardarPagoEnBaseDeDatos(string dni, string referencia, decimal monto)
        {
            try
            {
                // Obtener la instancia de la clase Conexion
                Conexion conexion = Conexion.GetInstancia();

                using (var connection = conexion.CrearConexion())
                {
                    connection.Open();

                    // Comando SQL para insertar un nuevo pago
                    var command = new MySqlCommand("INSERT INTO Pagos (DNICliente, Referencia, Valor, FechaPago, VencimientoPago) VALUES (@dni, @referencia, @monto, @fechaPago, @vencimientoPago)", connection);

                    // Asignar los parámetros del comando
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@referencia", referencia);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@fechaPago", DateTime.Now);
                    command.Parameters.AddWithValue("@vencimientoPago", DateTime.Now.AddMonths(1));

                    // Ejecutar el comando
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pago en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
