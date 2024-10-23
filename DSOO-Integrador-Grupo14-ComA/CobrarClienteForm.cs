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
            Clientes clientes = new Clientes();
            var cliente = clientes.ObtenerClientePorDni(dniCliente);

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
                    txtReferencia.Text = ""; // Para no socios, se puede llenar después
                    txtMonto.Text = ""; // Para no socios, se puede llenar después
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos del cliente.");
                this.Close(); // Cerrar el formulario si no hay datos
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            // Aquí podrías procesar el pago para no socios
            MessageBox.Show($"Pago procesado para {txtNombre.Text} {txtApellido.Text}.\nMonto: ${txtMonto.Text}");
            decimal monto = decimal.Parse( txtMonto.Text );
            // Aquí puedes agregar la lógica para guardar el pago en la base de datos
            GuardarPagoEnBaseDeDatos(dniCliente, txtReferencia.Text, monto);

            ReciboForm reciboForm = new ReciboForm(txtNombre.Text, txtApellido.Text, dniCliente, esSocio ? "socio" : "no-socio", txtReferencia.Text, monto);
            reciboForm.ShowDialog();
            this.Close(); // Cierra el formulario después de procesar el pago
        }

        private void GuardarPagoEnBaseDeDatos(string dni, string referencia, decimal monto)
        {
            // Obtener la instancia de la clase Conexion
            Conexion conexion = Conexion.GetInstancia();

            using (var connection = conexion.CrearConexion())
            {
                connection.Open(); // Abrir la conexión

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
    }
}
