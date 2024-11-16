using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class VerClientesForm : Form
    {
        // variable para saber que vista mostrar
        private string _tipoVista;


        public VerClientesForm(string tipoVista)
        {
            _tipoVista = tipoVista; // Asigna el tipo de vista recibido
            InitializeComponent();
        }

        private void VerClientesForm_Load(object sender, EventArgs e)
        {
            if (_tipoVista == "todos")
            {
                CargaGrilla("SELECT Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo FROM clientes");
            }
            else if (_tipoVista == "vencidosHoy")
            {
                // Consulta que selecciona los clientes cuyo pago vence hoy
                string query = @"
                    SELECT c.Nombre, c.Apellido, c.DNI, c.Tipo, 
                           p.Referencia, p.FechaPago, p.VencimientoPago
                    FROM clientes c
                    INNER JOIN pagos p ON c.DNI = p.DNICliente
                    WHERE p.VencimientoPago = CURDATE()";

                CargaGrilla(query);
            }
        }

        public void CargaGrilla(string query)
        {
            try
            {
                dgvClientes.Rows.Clear();

                // Establecer los encabezados de las columnas
                if (_tipoVista == "todos")
                {
                    dgvClientes.Columns.Clear();
                    dgvClientes.Columns.Add("Nombre", "Nombre");
                    dgvClientes.Columns.Add("Apellido", "Apellido");
                    dgvClientes.Columns.Add("DNI", "DNI");
                    dgvClientes.Columns.Add("Direccion", "Dirección");
                    dgvClientes.Columns.Add("Mail", "Mail");
                    dgvClientes.Columns.Add("Telefono", "Teléfono");
                    dgvClientes.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
                    dgvClientes.Columns.Add("Tipo", "Tipo");
                }
                else if (_tipoVista == "vencidosHoy")
                {
                    dgvClientes.Columns.Clear();
                    dgvClientes.Columns.Add("Nombre", "Nombre");
                    dgvClientes.Columns.Add("Apellido", "Apellido");
                    dgvClientes.Columns.Add("DNI", "DNI");
                    dgvClientes.Columns.Add("Tipo", "Tipo");
                    dgvClientes.Columns.Add("Referencia", "Referencia");
                    dgvClientes.Columns.Add("FechaPago", "Fecha de Pago");
                    dgvClientes.Columns.Add("VencimientoPago", "Vencimiento del Pago");
                }


                using (MySqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
                {
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;

                    sqlCon.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (_tipoVista == "todos")
                            {
                                int renglon = dgvClientes.Rows.Add(); // Agrega la fila al DataGridView.

                                dgvClientes.Rows[renglon].Cells[0].Value = reader.GetString(0); // Nombre
                                dgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1); // Apellido
                                dgvClientes.Rows[renglon].Cells[2].Value = reader.GetString(2); // DNI
                                dgvClientes.Rows[renglon].Cells[3].Value = reader.GetString(3); // Dirección
                                dgvClientes.Rows[renglon].Cells[4].Value = reader.GetString(4); // Mail
                                dgvClientes.Rows[renglon].Cells[5].Value = reader.GetString(5); // Teléfono
                                dgvClientes.Rows[renglon].Cells[6].Value = reader.GetDateTime(6).ToShortDateString(); // Fecha de Nacimiento
                                dgvClientes.Rows[renglon].Cells[7].Value = reader.GetString(7); // Tipo
                            }
                            if (_tipoVista == "vencidosHoy")
                            {
                                int renglon = dgvClientes.Rows.Add();

                                // Clientes
                                dgvClientes.Rows[renglon].Cells[0].Value = reader.GetString(0); // Nombre
                                dgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1); // Apellido
                                dgvClientes.Rows[renglon].Cells[2].Value = reader.GetString(2); // DNI
                                dgvClientes.Rows[renglon].Cells[3].Value = reader.GetString(3); // Tipo

                                // Pagos
                                dgvClientes.Rows[renglon].Cells[4].Value = reader.GetString(4); // Referencia
                                dgvClientes.Rows[renglon].Cells[5].Value = reader.GetDateTime(5).ToShortDateString(); // FechaPago
                                dgvClientes.Rows[renglon].Cells[6].Value = reader.GetDateTime(6).ToShortDateString(); // VencimientoPago

                            }
                        }
                    }else
                    {
                        if (_tipoVista == "vencidosHoy") { 
                            MessageBox.Show("No hay vencimientos en el dia de hoy para mostrar.");
                            this.Close();
                        } else
                        {
                            MessageBox.Show("No hay datos para mostrar.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // esto se agrego por hacer click donde no debia y si lo borro da error
        }
    }
}
